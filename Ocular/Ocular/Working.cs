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
    public partial class Working : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public Working()
        {
            InitializeComponent();
        }
        public void NewProject()
        {
            tabControl1.TabPages.Add(new ProjectPage());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(new MainPage());
            tabControl1.TabPages[0].CloseButtonVisible = false;
            tabControl1.TabIconSize = new Size(0, 0);
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
