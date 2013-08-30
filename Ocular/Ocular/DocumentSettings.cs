//Author: Rohan
//Date: 6/2/2013

#region Using Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#endregion

namespace Ocular
{
    namespace Document
    {
        public class DocumentSettings
        {
            #region Fields

            private List<frmDocument> docsOpen = new List<frmDocument>();
            private ScintillaAutoComplete autoComplete = new ScintillaAutoComplete();

            #endregion

            #region Properties

            public List<frmDocument> DocsOpen
            {
                get
                {
                    return docsOpen;
                }
            }

            #endregion

            #region Constructors

            public DocumentSettings()
            {
            }

            #endregion

            public void AddDocument(MdiTabControl.TabControl tabControl, string fullName, string displayName)
            {
                frmDocument document = new frmDocument();

                int index;

                //document.scintilla1.CharAdded += scintilla1_CharAdded;
                document.FormClosing += document_FormClosing;

                document.Name = fullName;
                document.Text = displayName;

                tabControl.TabPages.Add(document);
                this.docsOpen.Add(document);

                index = tabControl.TabPages.IndexOf(document);

                tabControl.TabIndex = index;
            }

            //Fixes a bug where newly opened files won't show after a file has been closed.
            //-Ro
            void document_FormClosing(object sender, FormClosingEventArgs e)
            {
                DocsOpen.RemoveAt(Program.mainForm.TabControl1.TabPages.SelectedIndex());
            }

            /*void scintilla1_CharAdded(object sender, ScintillaNET.CharAddedEventArgs e)
            {
                string text = Program.mainForm.CurrentScintilla.Text;
                char lastChar = text[text.Length - 1];

                //Only show the autocomplete if our last char is a letter
                if( char.IsLetter(lastChar) )
                    autoComplete.EnableAutoComplete(true, Program.mainForm.CurrentScintilla);
            }*/
        }
    }
}
