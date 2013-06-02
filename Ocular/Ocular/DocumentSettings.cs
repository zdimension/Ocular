//Author: Rohan
//Date: 6/2/2013

#region Using Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            public void AddDocument(MdiTabControl.TabControl tabControl, string docName)
            {
                frmDocument document = new frmDocument();

                document.scintilla1.CharAdded += scintilla1_CharAdded;
                document.Name = docName;

                tabControl.TabPages.Add(document);

                this.docsOpen.Add(document);
            }

            void scintilla1_CharAdded(object sender, ScintillaNET.CharAddedEventArgs e)
            {
                autoComplete.EnableAutoComplete(true, Program.mainForm.CurrentScintilla);
            }
        }
    }
}
