﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Ocular
{
    namespace Document
    {
        public partial class frmDocument : Form
        {
            #region Fields

            private string name;

            #endregion

            #region Properties

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    this.name = value;
                }
            }

            #endregion

            public frmDocument()
            {
                InitializeComponent();

                popupMenu = new AutocompleteMenu(fastTxt);
                popupMenu.MinFragmentLength = 1;
            }

            private void scintilla1_CharAdded(object sender, ScintillaNET.CharAddedEventArgs e)
            {
            }

            //Quick Save
            private void saveButton_Click(object sender, EventArgs e)
            {
                FileOpenSave quickSave = new FileOpenSave();
                quickSave.QuickFileSaveAs();
            }

            public OcularSyntaxHighlighter Highlighter = new OcularSyntaxHighlighter();

            private void fastTxt_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
            {
                if (fastTxt.Language == FastColoredTextBoxNS.Language.HTML)
                {
                    Highlighter.HTMLSyntaxHighlight(e.ChangedRange);
                }
            }

            private void frmDocument_Load(object sender, EventArgs e)
            {
                fastTxt.Text = LanguageHelper.BasicHTMLPage();

            }

            public AutocompleteMenu popupMenu;
        }
    }
}
