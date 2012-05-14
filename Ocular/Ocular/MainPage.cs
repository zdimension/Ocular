using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ocular
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
      
        private void label1_Click(object sender, EventArgs e)
            ///This code is used to create a new project form
        {
            Working frm = (Working)Application.OpenForms[0];
            frm.NewProject();       

        }
    }
}
