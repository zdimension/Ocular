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

        /// No need to have multiple ones.
        Working form = (Working)Application.OpenForms[0];
      
        // Deprecated: 05092012 - private void label1_Click(object sender, EventArgs e)
        //    ///This code is used to create a new project form
        //{
        //    Working frm = (Working)Application.OpenForms[0];
        //    frm.NewProject();       

        //}

        /// <summary>
        /// Creates and displays a new Project form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewProjectLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form.NewProject();
        }

        /// <summary>
        /// Creates and displays a new HTML form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewHTMLFileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Create New HTML Form
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates and displays a new CSS form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCSSFileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Create New CSS Form
            throw new NotImplementedException();
        }
    }
}
