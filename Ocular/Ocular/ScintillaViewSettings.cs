//Author: Rohan
//Date: 6/2/2013

#region Using Directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScintillaNET;

#endregion

namespace Ocular
{
    public class ScintillaViewSettings
    {
        #region Constructors

        public ScintillaViewSettings()
        {
        }

        #endregion

        /// <summary>
        /// Shows lines for the specified scintilla textbox
        /// </summary>
        /// <param name="showlines"></param>
        /// <param name="scintilla"></param>
        public void ShowLines(bool showlines, Scintilla scintilla)
        {
            if (showlines == false)
            {
                scintilla.Margins[0].Width = 0;
                scintilla.Margins[1].Width = 0;
                scintilla.Margins[2].Width = 0;
            }
            else
            {
                scintilla.Margins[0].Width = 50;
                scintilla.Margins[1].Width = 20;
                scintilla.Margins[2].Width = 20;
            }
        }
    }
}
