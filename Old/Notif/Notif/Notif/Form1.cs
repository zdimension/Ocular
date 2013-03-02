using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notif
{
    public partial class Notification : Form
    {
        public delegate void OnClicked();
        public event OnClicked Clicked;
        string title = "Error! Message not assigned!";
        string message = "Default message.";
        int msshowtime = 5000;
        public Notification(string Title, string Message, int ShowTime = 5000)
        {
            InitializeComponent();
            title = Title;
            message = Message;
            msshowtime = ShowTime;
        }
        Timer show = new Timer();
        Timer hide = new Timer();
        Timer sleep = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageLabel.MaximumSize = new Size(280, 0);
            MessageLabel.AutoSize = true;
            TitleLabel.Text = title;
            MessageLabel.Text = message;
            Opacity = 0;
            Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 300, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 160);
            show.Interval = 20;
            show.Tick += new EventHandler(t_Tick);
            show.Enabled = true;
            hide.Interval = 20;
            hide.Tick += new EventHandler(hide_Tick);
            sleep.Interval = msshowtime;
            sleep.Tick += new EventHandler(sleep_Tick);
        }

        void sleep_Tick(object sender, EventArgs e)
        {
            hide.Enabled = true;
            sleep.Enabled = false;
        }
        void hide_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 0)
            {
                this.Opacity -= 0.04;
            }
            else
            {
                this.Close();
            }
        }
        void t_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.9)
            {
                this.Opacity += 0.04;
            }
            else
            {
                show.Enabled = false;
                sleep.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            hide.Enabled = true;
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
            {
                Clicked();
            }
            else
            {

            }
        }
    }
}
