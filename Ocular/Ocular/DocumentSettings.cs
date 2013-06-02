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
                document.Name = docName;
                tabControl.TabPages.Add(document);

                this.docsOpen.Add(document);
            }
        }
    }
}
