using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Ocular.Dialogs;
using Transitions;
namespace Ocular
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        //Loads DLLs (DWM, RAM-Reducing thingy), declares relevant structures.
        [DllImport("dwmapi.dll", PreserveSig = true)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        }

        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern void DwmExtendFrameIntoClientArea
                        (IntPtr hwnd, ref MARGINS margins);

        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern bool DwmIsCompositionEnabled();

        [DllImport("psapi.dll")]
        private static extern int EmptyWorkingSet(IntPtr hwProc);

        private static void MinimizeFootprint()
        {
            EmptyWorkingSet(Process.GetCurrentProcess().Handle);
        }

        public void CloseWindow()
        {
            Transition.run(this, "Opacity", 0.0, new TransitionType_EaseInEaseOut(600));
            CloseTimer.Enabled = true;
        }
        public void HideWindow()
        {
            Transition.run(this, "Opacity", 0.0, new TransitionType_EaseInEaseOut(600));
            HideTimer.Enabled = true;
        }
        private void StartWindow_Load(object sender, EventArgs e)
        {
            try
            {
                //Animates form.
                Transition.run(this, "Opacity", 0.9, new TransitionType_EaseInEaseOut(1000));
                //Draws drop shadow using DWM.
                if (DwmIsCompositionEnabled())
                {
                    int val = 2;
                    DwmSetWindowAttribute(this.Handle, 2, ref val, 4);
                    MARGINS m = new MARGINS();
                    m.Left = 1;
                    m.Right = 0;
                    m.Bottom = 0;
                    m.Top = 1;
                    DwmExtendFrameIntoClientArea(this.Handle, ref m);
                }
                //Loads saved brightness and changes controls as necessary.
                BrightnessTrackBar.Value = Properties.Settings.Default.Brightness;
                this.BackColor = Color.FromArgb(255, Properties.Settings.Default.Brightness, Properties.Settings.Default.Brightness, Properties.Settings.Default.Brightness);
                foreach (Control Control in this.Controls)
                {
                    try
                    {
                        if (BrightnessTrackBar.Value < 75)
                        {
                            Control.ForeColor = Color.White;
                        }
                        else
                        {
                            Control.ForeColor = Color.FromArgb(255, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3);
                        }
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
            //Checks if Ocular directory exists, and runs the CreateDirectories background worker if it does not.
            //Please use the Ocular directory for storing projects and similar data.
            //Aurora: Fixed code that was unnecessary -- unused if section.
            if (!System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ocular"))
            {
                //Notif tells the user a folder was created. Also a nice test of Notif's capabilities
                Notif.Notification notification = new Notif.Notification("Directories created!", "Ocular has created directories for itself to store your projects! No action is needed.");
                notification.Show();
                CreateDirectories.RunWorkerAsync();
            }
            //If you add a new directory to the collection, please use a seperate if statement to check its existence.
            //This way, the directory will still be created for users who update the software. For example:
            //if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ocular\NewFolder"))
            //{

            //}
            //else
            //{
            //    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ocular\NewFolder");
            //}
        }
        private void StartWindow_BackColorChanged(object sender, EventArgs e)
        {
            //Changes control backcolors to fit form. Transparency causes visual errors with these controls, so this method
            //is used instead.
            Properties.Settings.Default.Save();
            NewProjectButton.BackColor = this.BackColor;
            OpenProjectButton.BackColor = this.BackColor;
            NewCSSFileButton.BackColor = this.BackColor;
            NewHTMLFileButton.BackColor = this.BackColor;
        }

        private void BrightnessTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            //Checks brightness and changes control forecolors to prevent them from become difficult to see.
            this.BackColor = Color.FromArgb(255, BrightnessTrackBar.Value, BrightnessTrackBar.Value, BrightnessTrackBar.Value);
            foreach (Control Control in this.Controls)
            {
                try
                {
                    if (BrightnessTrackBar.Value < 75)
                    {
                        Control.ForeColor = Color.White;
                    }
                    else
                    {
                        Control.ForeColor = Color.FromArgb(255, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3);
                    }
                    Properties.Settings.Default.Brightness = BrightnessTrackBar.Value;
                }
                catch
                {

                }
            }
            Properties.Settings.Default.Save();
        }

        private void MinFootprint_Tick(object sender, EventArgs e)
        {
            //Consistently minimises RAM usage.
            MinimizeFootprint();
        }

        //Following voids handle the MouseEnter colours for the 'Credits' and 'What's New' labels.
        private void CreditsLabel_MouseEnter(object sender, EventArgs e)
        {
            if (BrightnessTrackBar.Value < 75)
            {
                Transition.run(CreditsLabel, "ForeColor", Color.Gray, new TransitionType_EaseInEaseOut(500));
            }
            else
            {
                Transition.run(CreditsLabel, "ForeColor", Color.Black, new TransitionType_EaseInEaseOut(500));
            }
        }

        private void CreditsLabel_MouseLeave(object sender, EventArgs e)
        {
            if (BrightnessTrackBar.Value < 75)
            {
                Transition.run(CreditsLabel, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(500));
            }
            else
            {
                Transition.run(CreditsLabel, "ForeColor", Color.FromArgb(255, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3), new TransitionType_EaseInEaseOut(500));
            }
        }

        private void WhatsNewLabel_MouseEnter(object sender, EventArgs e)
        {
            if (BrightnessTrackBar.Value < 75)
            {
                Transition.run(WhatsNewLabel, "ForeColor", Color.Gray, new TransitionType_EaseInEaseOut(500));
            }
            else
            {
                Transition.run(WhatsNewLabel, "ForeColor", Color.Black, new TransitionType_EaseInEaseOut(500));
            }
        }

        private void WhatsNewLabel_MouseLeave(object sender, EventArgs e)
        {
            if (BrightnessTrackBar.Value < 75)
            {
                Transition.run(WhatsNewLabel, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(500));
            }
            else
            {
                Transition.run(WhatsNewLabel, "ForeColor", Color.FromArgb(255, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3), new TransitionType_EaseInEaseOut(500));
            }
        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            NewProject NP = new NewProject();
            DialogResult result = NP.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                OcularMain ocmain = new OcularMain();
                ocmain.Show();
                this.Hide();
            }
        }

        private void CreateDirectories_DoWork(object sender, DoWorkEventArgs e)
        {
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ocular");
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ocular\Projects");
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ocular\Plugins");
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ocular\Snippets");
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Ocular\Templates");
        }

        private void CreditsLabel_Click(object sender, EventArgs e)
        {
            Credits C = new Credits();
            C.ShowDialog();
        }

        private void BrightnessHelpLabel_MouseEnter(object sender, EventArgs e)
        {
            if (BrightnessTrackBar.Value < 75)
            {
                Transition.run(BrightnessHelpLabel, "ForeColor", Color.Gray, new TransitionType_EaseInEaseOut(500));
            }
            else
            {
                Transition.run(BrightnessHelpLabel, "ForeColor", Color.Black, new TransitionType_EaseInEaseOut(500));
            }
        }

        private void BrightnessHelpLabel_MouseLeave(object sender, EventArgs e)
        {
            if (BrightnessTrackBar.Value < 75)
            {
                Transition.run(BrightnessHelpLabel, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(500));
            }
            else
            {
                Transition.run(BrightnessHelpLabel, "ForeColor", Color.FromArgb(255, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3), new TransitionType_EaseInEaseOut(500));
            }
        }

        private void BrightnessHelpLabel_Click(object sender, EventArgs e)
        {
            BrightnessHelp BH = new BrightnessHelp();
            BH.ShowDialog();
        }

        private void WhatsNewLabel_Click(object sender, EventArgs e)
        {
            WhatsNew WN = new WhatsNew();
            WN.ShowDialog();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity.Equals(0))
            {
                this.Close();
            }
        }

        private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Confirm cdialog = new Confirm("Are you sure you want to quit Ocular?");
            if (cdialog.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                CloseWindow();
            }
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            if (BrightnessTrackBar.Value < 75)
            {
                Transition.run(ExitLabel, "ForeColor", Color.Gray, new TransitionType_EaseInEaseOut(500));
            }
            else
            {
                Transition.run(ExitLabel, "ForeColor", Color.Black, new TransitionType_EaseInEaseOut(500));
            }
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            if (BrightnessTrackBar.Value < 75)
            {
                Transition.run(ExitLabel, "ForeColor", Color.White, new TransitionType_EaseInEaseOut(500));
            }
            else
            {
                Transition.run(ExitLabel, "ForeColor", Color.FromArgb(255, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3, BrightnessTrackBar.Value / 3), new TransitionType_EaseInEaseOut(500));
            }
        }

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity.Equals(0))
            {
                this.Hide();
            }
        }

        private void RecentProjectsGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}