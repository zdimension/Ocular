using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;
namespace Ocular
{
    //DO NOT MODIFY OR DELETE THIS FORM. It is for testing purposes ONLY. All code here is experimental.
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.Width -= 50;
            this.Height -= 50;
            Transition T = new Transition(new TransitionType_EaseInEaseOut(400));
            T.add(this, "Opacity", 0.9);
            T.add(this, "Width", this.Width + 50);
            T.add(this, "Height", this.Height + 50);
            T.add(this, "Left", this.Left - 25);
            T.add(this, "Top", this.Top - 25);
            T.run();
        }
    }
}
