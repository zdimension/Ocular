using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ocular.TabForms
{
    public partial class File : Form
    {
        Language lang;
        public File()
        {
            InitializeComponent();
        }

        public File(Language lng)
        {
            lang = lng;
            switch (lang)
            {
                case Language.HTML:
                    break;
                case Language.CSS:
                    break;
                case Language.JS:
                    break;
                case Language.COLDFUSION:
                    break;
                default:
                    break;
            }
        }

        private void File_Load(object sender, EventArgs e)
        {

        }
    }

    public enum Language
    {
        HTML = 0,
        CSS = 1,
        JS = 2,
        COLDFUSION = 3
    }
}
