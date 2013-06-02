//Author: Rohan
//Date: 6/2/2013

#region Using Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using ScintillaNET;

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

        public OcularSyntaxHighlighting(string type, Scintilla scintilla)
        {
            this.SetGeneralHighlighting(type, scintilla);
        }

        #endregion

        /// <summary>
        /// Set's the highlighting to whatever parameter the user inputted.
        /// Will throw error if type is not found
        /// </summary>
        /// <param name="type"></param>
        public void SetGeneralHighlighting(string type, Scintilla scintilla)
        {
            switch (type)
            {
                case "html":
                    this.SetLanguage("html", scintilla);
                    this.language = "html";
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }

        /// <summary>
        /// Sets the specified language for the specified ScintillaNET.Scintilla
        /// </summary>
        /// <param name="richTextBox"></param>
        private void SetLanguage(string type, Scintilla scintilla)
        {
            scintilla.ConfigurationManager.Language = type;
            scintilla.ConfigurationManager.Configure();
        }
    }
}
