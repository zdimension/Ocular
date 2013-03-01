using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Ocular.TabForms
{
    public partial class File : Form
    {
        public readonly Style BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        public readonly Style BlueBoldStyle = new TextStyle(Brushes.Blue, null, FontStyle.Bold);
        public readonly Style BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        public readonly Style GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        public readonly Style MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        public readonly Style GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        public readonly Style BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        public readonly Style RedStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
        public readonly Style MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        public readonly Style AspTagStyle = new TextStyle(Brushes.Black, Brushes.Yellow, FontStyle.Regular);





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
                    txCode.Language = FastColoredTextBoxNS.Language.HTML;
                    break;
                case Language.CSS:
                    txCode.Language = FastColoredTextBoxNS.Language.Custom;
                    break;
                case Language.JS:
                    txCode.Language = FastColoredTextBoxNS.Language.JS;
                    break;
                case Language.COLDFUSION:
                    txCode.Language = FastColoredTextBoxNS.Language.Custom;
                    break;
                case Language.ASP:
                    txCode.Language = FastColoredTextBoxNS.Language.HTML;
                    break;
                case Language.ASPNET:
                    txCode.Language = FastColoredTextBoxNS.Language.Custom;
                    break;
                case Language.PHP:
                    txCode.Language = FastColoredTextBoxNS.Language.PHP;
                    break;
                case Language.VBSCRIPT:
                    txCode.Language = FastColoredTextBoxNS.Language.VB;
                    break;
                default:
                    break;
            }
        }

        public File(Language lng, string fileName)
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
            txCode.SyntaxHighlighter = new Ocular.SyntaxHighlighter();
            //(txCode.SyntaxHighlighter as SyntaxHighlighter).ASPNETSyntaxHighlight(txCode.Range);
        }

        

        private void toolStripButton12_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripButton12.Checked)
            {
                toolStripButton12.Image = Properties.Resources._checked;
            }
            else
            {
                toolStripButton12.Image = Properties.Resources._unchecked;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnHTML_Click(object sender, EventArgs e)
        {

        }

        private void btnHTML_MouseEnter(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Equals(btnHTML))
            {
btnHTML.Image = Properties.Resources.btnHtmlHover;
            }
            else
            {
                btnCSS.Image = Properties.Resources.btnCSSHover;
            }            
        }

        private void btnHTML_MouseMove(object sender, MouseEventArgs e)
        {
            if (((PictureBox)sender).Equals(btnHTML))
            {
                btnHTML.Image = Properties.Resources.btnHtmlHover;
            }
            else
            {
                btnCSS.Image = Properties.Resources.btnCSSHover;
            }      
        }

        private void btnHTML_MouseLeave(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Equals(btnHTML))
            {
                if(checkg == "html")
                {
                btnHTML.Image = Properties.Resources.btnHtml;
                }
                else
                {
                    btnHTML.Image = Properties.Resources.btnHtmlUnchecked;
                }
            }
            else
            {
                if (checkg == "css")
                {
                    btnCSS.Image = Properties.Resources.btnCSS;
                }
                else
                {
                    btnCSS.Image = Properties.Resources.btnCSSUnchecked;
                }
            }      
        }

        private void btnHTML_MouseDown(object sender, MouseEventArgs e)
        {
            if (((PictureBox)sender).Equals(btnHTML))
            {
                btnHTML.Image = Properties.Resources.btnHtmlDown;
            }
            else
            {
                btnCSS.Image = Properties.Resources.btnCSSDown;
            }      
        }

        private void btnHTML_MouseUp(object sender, MouseEventArgs e)
        {
            if (((PictureBox)sender).Equals(btnHTML))
            {
                btnHTML.Image = Properties.Resources.btnHtmlHover;
            }
            else
            {
                btnCSS.Image = Properties.Resources.btnCSSHover;
            }      
        }

        string checkg = "html";

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previewToolStripMenuItem.Checked = false;
            tbcMain.SelectedTab = tbxCode;

            toolStripDropDownButton2.Text = "Code";
            toolStripDropDownButton2.Image = Properties.Resources.page_code;
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeToolStripMenuItem.Checked = false;
            tbcMain.SelectedTab = tbxPreview;

            toolStripDropDownButton2.Text = "Preview";
            toolStripDropDownButton2.Image = Properties.Resources.page_magnifier;
        }

        private void txCode_Load(object sender, EventArgs e)
        {

        }

        private void txCode_TextChanged(object sender, EventArgs e)
        {

        }
    }



   
}
namespace Ocular
{
 public enum Language
    {
        HTML = 0,
        CSS = 1,
        JS = 2,
        COLDFUSION = 3,
        ASP = 4,
        ASPNET = 5,
        PHP = 6,
        VBSCRIPT = 7
    }
}
