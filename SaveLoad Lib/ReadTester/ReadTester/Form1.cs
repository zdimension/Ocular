using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ocular.FileManagement.ReadHelper helper = new Ocular.FileManagement.ReadHelper(textBox1.Text, textBox2.Text);
            helper.Run();
        }
    }
}
