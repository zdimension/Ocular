using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Transitions;
namespace Ocular
{
    [DefaultEvent("PlainButton_Click")]public partial class PlainButton : UserControl
    {
        //DO NOT MODIFY THIS CONTROL. Also, please do not use the code in your own applications,
        //since much of it is from my MetroToolkit project, which is supposed to be closed source. -Maxwilly
        
        //Defines values for properties.
        Image TIMG = default(Image);
        string TText = null;

        //Defines properties. See property descriptions for information.
        [Description("Sets the image displayed by the button.")]
        public Image ButtonImage
        {
            get { return TIMG; }
            set
            {
                TIMG = value;
                Refresh();
            }
        }

        [Description("The title text rendered by the button.")]
        public string ButtonText
        {
            get { return TText; }
            set
            {
                TText = value;
                Refresh();
            }
        }
        public PlainButton()
        {
            InitializeComponent();
        }

        private void PlainButton_Load(object sender, EventArgs e)
        {
            //Replaces transparency, since transparency causes visual defects.
            this.BackColor = ParentForm.BackColor;
        }

        private void PlainButton_MouseEnter(object sender, EventArgs e)
        {
            Transition.run(this, "BackColor", Color.ForestGreen, new TransitionType_EaseInEaseOut(200));
            this.Refresh();
        }

        private void PlainButton_MouseLeave(object sender, EventArgs e)
        {
            Transition.run(this, "BackColor", ParentForm.BackColor, new TransitionType_EaseInEaseOut(200));
            this.Refresh();
        }

        private void PlainButton_Paint(object sender, PaintEventArgs e)
        {
            //Applies properties as appropriate.
            PlainButtonImage.Image = ButtonImage;
            PlainButtonText.Text = ButtonText;
            PlainButtonText.ForeColor = this.ForeColor;
        }

        private void PlainButtonText_MouseEnter(object sender, EventArgs e)
        {
            Transition.run(this, "BackColor", Color.ForestGreen, new TransitionType_EaseInEaseOut(200));
            this.Refresh();
        }

        private void PlainButtonImage_MouseEnter(object sender, EventArgs e)
        {
            Transition.run(this, "BackColor", Color.ForestGreen, new TransitionType_EaseInEaseOut(200));
            this.Refresh();
        }

        private void PlainButtonImage_MouseLeave(object sender, EventArgs e)
        {
            Transition.run(this, "BackColor", ParentForm.BackColor, new TransitionType_EaseInEaseOut(200));
            this.Refresh();
        }

        private void PlainButtonText_MouseLeave(object sender, EventArgs e)
        {
            Transition.run(this, "BackColor", ParentForm.BackColor, new TransitionType_EaseInEaseOut(200));
            this.Refresh();
        }

        private void PlainButtonText_Click(object sender, EventArgs e)
        {
            //Acts as if the main control has been clicked.
            InvokeOnClick(this, e);
        }

        private void PlainButtonImage_Click(object sender, EventArgs e)
        {
            //Acts as if the main control has been clicked.
            InvokeOnClick(this, e);
        }

        private void PlainButton_Click(object sender, EventArgs e)
        {
            //Here to prevent errors. Do not add code here, but instead on the form in which you use the
            //control (using PlainButton1_Click or whatever you have called the control).
        }
    }
}
