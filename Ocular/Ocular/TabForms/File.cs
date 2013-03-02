using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            InitializeComponent();
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
                    txCode.Language = FastColoredTextBoxNS.Language.Custom;
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
            InitializeComponent();
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
                    txCode.Language = FastColoredTextBoxNS.Language.Custom;
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
            txCode.Text = System.IO.File.ReadAllText(fileName);
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
        #region Styles

        /// <summary>
        /// String style
        /// </summary>
        public Style StringStyle { get; set; }
        /// <summary>
        /// Comment style
        /// </summary>
        public Style CommentStyle { get; set; }
        /// <summary>
        /// Number style
        /// </summary>
        public Style NumberStyle { get; set; }
        /// <summary>
        /// C# attribute style
        /// </summary>
        public Style AttributeStyle { get; set; }
        /// <summary>
        /// Class name style
        /// </summary>
        public Style ClassNameStyle { get; set; }
        /// <summary>
        /// Keyword style
        /// </summary>
        public Style KeywordStyle { get; set; }
        /// <summary>
        /// Style of tags in comments of C#
        /// </summary>
        public Style CommentTagStyle { get; set; }

        /// <summary>
        /// HTML attribute value style
        /// </summary>
        public Style AttributeValueStyle { get; set; }
        /// <summary>
        /// HTML tag brackets style
        /// </summary>
        public Style TagBracketStyle { get; set; }

        /// <summary>
        /// ASP.NET < % tag brackets style
        /// </summary>
        public Style SpTagBracketStyle { get; set; }

        /// <summary>
        /// HTML tag name style
        /// </summary>
        public Style TagNameStyle { get; set; }
        /// <summary>
        /// HTML Entity style
        /// </summary>
        public Style HtmlEntityStyle { get; set; }

        /// <summary>
        /// ASP.NET Entity style
        /// </summary>
        public Style ASPNETEntityStyle { get; set; }


        /// <summary>
        /// Variable style
        /// </summary>
        public Style VariableStyle { get; set; }
        /// <summary>
        /// Specific PHP keyword style
        /// </summary>
        public Style KeywordStyle2 { get; set; }
        /// <summary>
        /// Specific PHP keyword style
        /// </summary>
        public Style KeywordStyle3 { get; set; }

        /// <summary>
        /// SQL Statements style
        /// </summary>
        public Style StatementsStyle { get; set; }
        /// <summary>
        /// SQL Functions style
        /// </summary>
        public Style FunctionsStyle { get; set; }
        /// <summary>
        /// SQL Types style
        /// </summary>
        public Style TypesStyle { get; set; }

        #endregion
        public void InitStyleSchema(Language lang)
        {
            switch (lang)
            {
                case Language.VBSCRIPT:
                    StringStyle = BrownStyle;
                    CommentStyle = GreenStyle;
                    NumberStyle = MagentaStyle;
                    ClassNameStyle = BoldStyle;
                    KeywordStyle = BlueStyle;
                    break;
                case Language.HTML:
                    CommentStyle = GreenStyle;
                    TagBracketStyle = BlueStyle;
                    TagNameStyle = MaroonStyle;
                    AttributeStyle = RedStyle;
                    AttributeValueStyle = BlueStyle;
                    HtmlEntityStyle = RedStyle;
                    break;
                case Language.ASP:
                    CommentStyle = GreenStyle;
                    TagBracketStyle = BlueStyle;
                    TagNameStyle = MaroonStyle;
                    AttributeStyle = RedStyle;
                    AttributeValueStyle = BlueStyle;
                    HtmlEntityStyle = RedStyle;
                    break;
                case Language.ASPNET:
                    CommentStyle = GreenStyle;
                    TagBracketStyle = BlueStyle;
                    TagNameStyle = MaroonStyle;
                    AttributeStyle = RedStyle;
                    AttributeValueStyle = BlueStyle;
                    HtmlEntityStyle = RedStyle;
                    SpTagBracketStyle = AspTagStyle;
                    break;
                case Language.JS:
                    StringStyle = BrownStyle;
                    CommentStyle = GreenStyle;
                    NumberStyle = MagentaStyle;
                    KeywordStyle = BlueStyle;
                    KeywordStyle = BlueStyle;
                    break;
                case Language.PHP:
                    StringStyle = RedStyle;
                    CommentStyle = GreenStyle;
                    NumberStyle = RedStyle;
                    VariableStyle = MaroonStyle;
                    KeywordStyle = MagentaStyle;
                    KeywordStyle2 = BlueStyle;
                    KeywordStyle3 = GrayStyle;
                    break;
            }
        }
        static readonly Platform platformType = PlatformType.GetOperationSystemPlatform();
        public static RegexOptions RegexCompiledOption
        {
            get
            {
                if (platformType == Platform.X86)
                    return RegexOptions.Compiled;
                else
                    return RegexOptions.None;
            }
        }
        #region ASPNET
        Regex ASPNETTagRegex, ASPNETTagNameRegex, ASPNETEndTagRegex, ASPNETSpTagRegex, ASPNETAttrRegex, ASPNETAttrValRegex, ASPNETCommentRegex1, ASPNETCommentRegex2, ASPNETEntityRegex, ASPNETTagContentRegex;

        void InitASPNETRegex()
        {
            ASPNETCommentRegex1 = new Regex(@"(<!--.*?-->)|(<!--.*)", RegexOptions.Singleline | RegexCompiledOption);
            ASPNETCommentRegex2 = new Regex(@"(<!--.*?-->)|(.*-->)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexCompiledOption);
            ASPNETTagRegex = new Regex(@"<|/>|</|>", RegexCompiledOption);
            ASPNETSpTagRegex = new Regex(@"<%|%>", RegexCompiledOption);
            ASPNETTagNameRegex = new Regex(@"<(?<range>[!\w:]+)", RegexCompiledOption);
            ASPNETEndTagRegex = new Regex(@"</(?<range>[\w:]+)>", RegexCompiledOption);
            ASPNETTagContentRegex = new Regex(@"<[^>]+>", RegexCompiledOption);
            ASPNETAttrRegex = new Regex(@"(?<range>[\w\d\-]{1,20}?)='[^']*'|(?<range>[\w\d\-]{1,20})=""[^""]*""|(?<range>[\w\d\-]{1,20})=[\w\d\-]{1,20}", RegexCompiledOption);
            ASPNETAttrValRegex = new Regex(@"[\w\d\-]{1,20}?=(?<range>'[^']*')|[\w\d\-]{1,20}=(?<range>""[^""]*"")|[\w\d\-]{1,20}=(?<range>[\w\d\-]{1,20})", RegexCompiledOption);
            ASPNETEntityRegex = new Regex(@"\&(amp|gt|lt|nbsp|quot|apos|copy|reg|#[0-9]{1,8}|#x[0-9a-f]{1,8});", RegexCompiledOption | RegexOptions.IgnoreCase);
        }
        #endregion
        private void txCode_TextChanged(object sender,  TextChangedEventArgs e)
        {
            /*switch (lang)
            {
                case Language.COLDFUSION:
                    break;
                case Language.ASPNET:*/
                    e.ChangedRange.tb.CommentPrefix = null;
            e.ChangedRange.tb.LeftBracket = '<';
            e.ChangedRange.tb.RightBracket = '>';
            e.ChangedRange.tb.LeftBracket2 = '(';
            e.ChangedRange.tb.RightBracket2 = ')';
            //clear style of changed e.ChangedRange
            e.ChangedRange.ClearStyle(CommentStyle, TagBracketStyle, TagNameStyle, AttributeStyle, AttributeValueStyle, ASPNETEntityStyle);
            //
                    
            if (ASPNETTagRegex == null)
                InitASPNETRegex();
            //comment highlighting
            e.ChangedRange.SetStyle(CommentStyle, ASPNETCommentRegex1);
            e.ChangedRange.SetStyle(CommentStyle, ASPNETCommentRegex2);
            //tag brackets highlighting
            e.ChangedRange.SetStyle(TagBracketStyle, ASPNETTagRegex);
            // '<%' tag brackets highlighting
            e.ChangedRange.SetStyle(SpTagBracketStyle, ASPNETSpTagRegex);
            //tag name
            e.ChangedRange.SetStyle(TagNameStyle, ASPNETTagNameRegex);
            //end of tag
            e.ChangedRange.SetStyle(TagNameStyle, ASPNETEndTagRegex);
            //attributes
            e.ChangedRange.SetStyle(AttributeStyle, ASPNETAttrRegex);
            //attribute values
            e.ChangedRange.SetStyle(AttributeValueStyle, ASPNETAttrValRegex);
            //ASPNET entity
            e.ChangedRange.SetStyle(ASPNETEntityStyle, ASPNETEntityRegex);

            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();
            //set folding markers
            e.ChangedRange.SetFoldingMarkers("<head", "</head>", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers("<body", "</body>", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers("<table", "</table>", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers("<form", "</form>", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers("<div", "</div>", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers("<script", "</script>", RegexOptions.IgnoreCase);
            e.ChangedRange.SetFoldingMarkers("<tr", "</tr>", RegexOptions.IgnoreCase);
                /*    break;
                case Language.ASP:
                    break;
            }*/
        }

        private void btnRenderTrident_Click(object sender, EventArgs e)
        {
            btnRenderGecko.Checked = false;
            btnRenderWebkit.Checked = false;

            tbcPreview.SelectedTab = tbxTrident;

            btnRender.Text = "Trident (IE)";
        }

        private void btnRenderGecko_Click(object sender, EventArgs e)
        {
            btnRenderTrident.Checked = false;
            btnRenderWebkit.Checked = false;

            tbcPreview.SelectedTab = tbxGecko;

            btnRender.Text = "Gecko (Firefox)";
        }

        private void btnRenderWebkit_Click(object sender, EventArgs e)
        {
            btnRenderGecko.Checked = false;
            btnRenderTrident.Checked = false;

            tbcPreview.SelectedTab = tbxWebkit;

            btnRender.Text = "Webkit (Chrome/Safari)";
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
