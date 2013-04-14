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
    public partial class frmMain : Form

    {
        public frmMain()
        {
            InitializeComponent();
            tabControl1.GetTabRegion += new MdiTabControl.TabControl.GetTabRegionEventHandler(TabControl1_GetTabRegion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmDocument nform = new frmDocument();
            tabControl1.TabPages.Add(nform);
        }
              
        private void TabControl1_GetTabRegion(object sender, MdiTabControl.TabControl.GetTabRegionEventArgs e)
        {
            e.Points[1] = new Point(0, 0);
            e.Points[3] = new Point(e.TabWidth - 1, 0);
        }

        private void PropertiesCollapse_Click(object sender, EventArgs e)
        {
          
        }
    }
}
