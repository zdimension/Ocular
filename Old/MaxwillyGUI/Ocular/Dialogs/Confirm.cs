using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Transitions;
namespace Ocular.Dialogs
{
    public partial class Confirm : Form
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
        string messagelabeltext = "";
        public Confirm(string message)
        {
            InitializeComponent();
            messagelabeltext = message;   
        }

        private void OkButton_Load(object sender, EventArgs e)
        {

        }

        private void NoButton_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            MessageLabel.MaximumSize = new Size(393, 0);
            MessageLabel.AutoSize = true;
            if (MessageLabel.Text != "")
            {
                MessageLabel.Text = messagelabeltext;
            }
            //Animates form.
            Transition.run(this, "Opacity", 0.9, new TransitionType_EaseInEaseOut(600));
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
                        Control.ForeColor = Color.White;
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
            OkButton.ForeColor = Color.Black;
            NoButton.ForeColor = Color.Black;
            CancelButton.ForeColor = Color.Black;
        }

        private void CancelButton_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Transition.run(this, "Opacity", 0.0, new TransitionType_EaseInEaseOut(600));
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            Transition.run(this, "Opacity", 0.0, new TransitionType_EaseInEaseOut(600));
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            Transition.run(this, "Opacity", 0.0, new TransitionType_EaseInEaseOut(600));
        }
    }
}
