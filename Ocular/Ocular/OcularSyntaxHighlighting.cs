#region Using Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

#endregion

namespace Ocular
{
    public class OcularSyntaxHighlighting
    {
        //Notes:
        //Syntax highlighting might become laggy when opening large files 
        //as it updates on every keypress inside the active control.

        #region Fields

        private string language;

        #endregion

        #region Properties

        public string Language
        {
            get
            {
                return language;
            }
        }

        #endregion

        #region Constructors

        public OcularSyntaxHighlighting()
        {
        }

        public OcularSyntaxHighlighting(string type, RichTextBox richTextBox)
        {
            SetGeneralHighlighting(type, richTextBox);
        }

        #endregion

        /// <summary>
        /// Set's the highlighting to whatever parameter the user inputted.
        /// Will throw error if type is not found
        /// </summary>
        /// <param name="type"></param>
        public void SetGeneralHighlighting(string type, RichTextBox richTextBox)
        {
            switch (type)
            {
                case "html":
                    this.SetHtmlHighlighting(richTextBox);
                    this.language = "html";
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }

        /// <summary>
        /// Sets html highlighting for the specified Systems.Windows.Forms.RichTextBox
        /// </summary>
        /// <param name="richTextBox"></param>
        /// 
        //NOTE: Not the best...it would be better to use a control like Scintilla to achieve this goal.
        private void SetHtmlHighlighting(RichTextBox richTextBox)
        {
            int matchIndex = 0;
            int matchLength;
            int index;

            string[] keywords = { "!doctype", "a" ,"button" ,"code" ,"font" ,"form" ,"h" ,"h1" ,"h2" ,"h3" ,"h4" ,"h5" ,"h6" ,"head" ,"html" ,"img" ,"input" ,"link" ,"href" ,"title" };
            string text = richTextBox.Text;

            //Check if the array 'keywords' contains the string 'text' (text updates everytime the richtextbox text is changed since we call this function on that event)
            var matches = keywords.Where(s => text.Contains(s));

            if (matches.Count() < 1)
                return;

            int cursorPosition = richTextBox.SelectionStart;

            foreach (string c in matches)
            {
                matchLength = c.Length;
                index = richTextBox.Text.IndexOf(c, richTextBox.SelectionStart - matchLength);

                if (index != -1)
                {
                    richTextBox.Select(index, matchLength);
                    richTextBox.SelectionColor = Color.Blue;

                    richTextBox.SelectionStart = cursorPosition;
                    richTextBox.SelectionColor = Color.Black;
                }
            }
        }
    }
}
