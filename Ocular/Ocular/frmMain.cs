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
        #region Fields

        private Document.DocumentSettings docSettings = new Document.DocumentSettings();

        #endregion

        #region Properties

        public ScintillaNET.Scintilla CurrentScintilla
        {
            get
            {
                return docSettings.DocsOpen[tabControl1.TabPages.SelectedIndex()].scintilla1;
            }
        }

        #endregion

        public frmMain()
        {
            InitializeComponent();
            tabControl1.GetTabRegion += new MdiTabControl.TabControl.GetTabRegionEventHandler(TabControl1_GetTabRegion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.docSettings.AddDocument(tabControl1, "Untitled");
        }
              
        private void TabControl1_GetTabRegion(object sender, MdiTabControl.TabControl.GetTabRegionEventArgs e)
        {
            e.Points[1] = new Point(0, 0);
            e.Points[3] = new Point(e.TabWidth - 1, 0);
        }

        private void PropertiesCollapse_Click(object sender, EventArgs e)
        {
          
        }

        //Show line numbers event
        //If clicked, shows the number of each line for Scintilla
        private void showLineNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScintillaViewSettings view = new ScintillaViewSettings();
            view.ShowLines(true, CurrentScintilla);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.docSettings.AddDocument(tabControl1, "Untitled");
        }
    }
}
