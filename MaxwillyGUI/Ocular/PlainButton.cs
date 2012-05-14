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
    public partial class PlainButton : UserControl
    {
        Image TIMG = default(Image);
        string TText = null;
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

        private void PlainButton_ForeColorChanged(object sender, EventArgs e)
        {
            
        }

        private void PlainButton_Paint(object sender, PaintEventArgs e)
        {
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
    }
}
