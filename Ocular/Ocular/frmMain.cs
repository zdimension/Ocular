using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ocular.Document;

namespace Ocular
{
    public partial class frmMain : Form
    {
        #region Fields

        private Document.DocumentSettings docSettings = new Document.DocumentSettings();

        public Document.DocumentSettings DocumentSettings
        {
            get
            {
                return docSettings;
            }
        }

        #endregion

        #region Properties

        /*public ScintillaNET.Scintilla CurrentScintilla
        {
            get
            {
                return docSettings.DocsOpen[tbxMain.TabPages.SelectedIndex()].scintilla1;
            }
        }*/

        public FastColoredTextBoxNS.FastColoredTextBox CurrentBox
        {
            get
            {
                return docSettings.DocsOpen[tbxMain.TabPages.SelectedIndex()].fastTxt;
            }
        }

        public MdiTabControl.TabControl TabControl1
        {
            get
            {
                return tbxMain;
            }
        }

        #endregion

        public frmMain()
        {
            InitializeComponent();
            tbxMain.GetTabRegion += new MdiTabControl.TabControl.GetTabRegionEventHandler(TabControl1_GetTabRegion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.docSettings.AddDocument(tbxMain, "Untitled", "Untitled");
            showLineNumbersToolStripMenuItem.Checked = CurrentBox.ShowLineNumbers;
        }
              
        private void TabControl1_GetTabRegion(object sender, MdiTabControl.TabControl.GetTabRegionEventArgs e)
        {
            //???
            //-Ro
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
            //ScintillaViewSettings view = new ScintillaViewSettings();
            //view.ShowLines(true, CurrentScintilla);
            CurrentBox.ShowLineNumbers = !CurrentBox.ShowLineNumbers;
            showLineNumbersToolStripMenuItem.Checked = CurrentBox.ShowLineNumbers;
        }

        //New File
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.docSettings.AddDocument(tbxMain, "Untitled", "Untitled");
        }

        //Open File
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOpenSave open = new FileOpenSave();
            open.OpenFile(tbxMain);
        }

        private void saveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOpenSave open = new FileOpenSave();
            open.SaveFileAs();
        }


    }
}
