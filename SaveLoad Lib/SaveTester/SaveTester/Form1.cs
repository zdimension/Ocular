using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaveTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ocular.FileManagement.FileData svdata = new Ocular.FileManagement.FileData();
            svdata.ProjectName = "BlahExample";
            svdata.PathToProjectFolder = textBox1.Text;
            svdata.PathToNewProject = textBox2.Text;
            Ocular.FileManagement.SaveHelper helper = new Ocular.FileManagement.SaveHelper(svdata);
            helper.Save();
        }
    }
}
