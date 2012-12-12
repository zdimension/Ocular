using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Ocular.Dialogs;
using Transitions;
namespace Ocular
{
    public partial class OpenProject : Form
    {
        public OpenProject()
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

        private void NewProject_Load(object sender, EventArgs e)
        {
            //Animates form.
            Transition.run(this, "Opacity", 0.9,new TransitionType_EaseInEaseOut(1000));
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
            this.BackColor = Color.FromArgb(255, Properties.Settings.Default.Brightness, Properties.Settings.Default.Brightness, Properties.Settings.Default.Brightness);
            foreach (Control Control in this.Controls)
            {
                try
                {
                    if (Properties.Settings.Default.Brightness < 75)
                    {
                        Control.ForeColor = Color.Black;
                    }
                    else
                    {
                        Control.ForeColor = Color.FromArgb(255, Properties.Settings.Default.Brightness / 3, Properties.Settings.Default.Brightness / 3, Properties.Settings.Default.Brightness / 3);
                    }
                }
                catch
                {

                }
            }
        }

        private void MinFootprint_Tick(object sender, EventArgs e)
        {
            //Consistently minimises RAM usage.
            MinimizeFootprint();
        }

        

        private void SelectLocationButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ocular Projects (*.ocproj)|*.ocproj";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ProjectLocationBox.Text = ofd.FileName;
            }
        }

        private void OKButton_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //Load the file here when ready
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void ProjectLocationBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}