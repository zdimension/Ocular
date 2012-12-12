using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;
using System.Runtime.InteropServices;
using Transitions;
namespace Ocular
{
    public partial class OcularMain : Form
    {
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
        public OcularMain()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
        private void Ocular_Load(object sender, EventArgs e)
        {
            try
            {
               
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
                Transition.run(this, "Opacity", 1, new TransitionType_EaseInEaseOut(1000));
            }
            catch
            {

            }
            MainDocControl.TabBackHighColor = Color.FromArgb(240, 240, 240);
            t.Tick += t_Tick;
            t.Interval = 50;
            
            Form S = new DocumentWindow();
            S.Text = "HTML Editor";
            S.Icon = System.Drawing.Icon.FromHandle(Properties.Resources.NewHTML.GetHicon());
            S.Tag = MainDocControl.TabPages.Add(S);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (MainDocControl.TabPages.Count == 1)
            {
                foreach (MdiTabControl.TabPage page in MainDocControl.TabPages)
                {
                    page.CloseButtonVisible = false;  
                }
            }
            else if (MainDocControl.TabPages.Count == 0)
            {
                Close();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(MainDocControl.TabPages.Count.ToString());
                MainDocControl.CloseButtonVisible = true;
            }
        }

        void MainDocControl_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void MainDocControl_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainDocControl_Load(object sender, EventArgs e)
        {

        }

        private void MainDocControl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
                Transition.run(CloseButton, "ForeColor", Color.Green, new TransitionType_EaseInEaseOut(200));
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
                Transition.run(CloseButton, "ForeColor", Color.Gray, new TransitionType_EaseInEaseOut(200));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeLabel_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

    }
}
