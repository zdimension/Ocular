//Author: Rohan
//Date: 6/2/2013

#region Using Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScintillaNET;
using System.IO;
using System.Threading;

#endregion

namespace Ocular
{
    namespace Document
    {
        public class FileOpenSave
        {
            #region Constructors

            public FileOpenSave()
            {
            }

            #endregion

            /// <summary>
            /// Opens a file into the specified MdiTabControl.TabControl
            /// </summary>
            /// <param name="tabControl"></param>
            public void OpenFile(MdiTabControl.TabControl tabControl)
            {
                //OpenFileDialog instance
                OpenFileDialog openFileDialog = new OpenFileDialog();

                //DialogResults
                DialogResult result = openFileDialog.ShowDialog();
                DialogResult OK = DialogResult.OK;

                //strings
                string filename;
                string fileText;
                string shortFileName;

                //Scintilla Component
                FastColoredTextBoxNS.FastColoredTextBox currentBox;
                //Document Settings class
                DocumentSettings docSettings;

                if (result == OK)
                {
                    filename = openFileDialog.FileName;
                    shortFileName = Path.GetFileName(filename);

                    docSettings = Program.mainForm.DocumentSettings;

                    //Add a new document
                    docSettings.AddDocument(tabControl, filename, shortFileName);
                    //Now we can save our current Scintilla component since we change the index after adding
                    //a new document
                    currentBox = Program.mainForm.CurrentBox;

                    //Read the text from the selected file
                    fileText = File.ReadAllText(filename);

                    //Set our Scintilla File Text
                    currentBox.Text = fileText;
                }
            }

            public void SaveFileAs()
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                //DialogResults
                DialogResult result = saveFileDialog.ShowDialog();
                DialogResult OK = DialogResult.OK;

                //strings
                string filename;
                string fileText;

                //Scintilla Component
                Scintilla currentScintilla;
                FastColoredTextBoxNS.FastColoredTextBox currentBox;
                DocumentSettings docSettings;

                if (result == OK)
                {
                    filename = saveFileDialog.FileName;

                    currentBox = Program.mainForm.CurrentBox;

                    //Read the text from the selected file
                    fileText = currentBox.Text;

                    File.WriteAllText(filename, fileText);

                    docSettings = Program.mainForm.DocumentSettings;

                    docSettings.DocsOpen[Program.mainForm.TabControl1.TabPages.SelectedIndex()].Name = filename;
                    docSettings.DocsOpen[Program.mainForm.TabControl1.TabPages.SelectedIndex()].Text = Path.GetFileName(filename);
                }
            }

            public void QuickFileSaveAs()
            {
                int index = Program.mainForm.TabControl1.TabPages.SelectedIndex();

                DocumentSettings docSettings = Program.mainForm.DocumentSettings;

                string name = docSettings.DocsOpen[index].Name;
                //Scintilla currentScintilla = docSettings.DocsOpen[index].scintilla1;
                FastColoredTextBoxNS.FastColoredTextBox currentBox = docSettings.DocsOpen[index].fastTxt;

                //Even if a file is named 'Untitled' without the extension, the docSettings.DocsOpen[index].Name
                //has always has an extension so only non-saved files will have a name of 'Untitled'
                if (name != "Untitled")
                {
                    File.WriteAllText(name, currentBox.Text);
                }
            }
        }
    }
}
