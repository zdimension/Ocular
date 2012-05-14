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
namespace Ocular
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

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

        private void StartWindow_Load(object sender, EventArgs e)
        {
            if (DwmIsCompositionEnabled())
            {
                int val = 2;
                DwmSetWindowAttribute(this.Handle, 2, ref val, 4);
                MARGINS m = new MARGINS();
                m.Left = 1;
                m.Right = 1;
                m.Bottom = 1;
                m.Top = 1;
                DwmExtendFrameIntoClientArea(this.Handle, ref m);
            }
            BrightnessTrackBar.Value = Properties.Settings.Default.Brightness;
            this.BackColor = Color.FromArgb(255, Properties.Settings.Default.Brightness, Properties.Settings.Default.Brightness, Properties.Settings.Default.Brightness);
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
        }

        private void StartWindow_BackColorChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            NewProjectButton.BackColor = this.BackColor;
            OpenProjectButton.BackColor = this.BackColor;
            NewCSSFileButton.BackColor = this.BackColor;
            NewHTMLFileButton.BackColor = this.BackColor;
        }

        private void BrightnessTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
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
    }
}