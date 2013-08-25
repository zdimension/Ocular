using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastColoredTextBoxNS;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Ocular
{
    public class OcularSyntaxHighlighter : IDisposable
    {
        public void Dispose()
        {
        }

        /*
         * [A-Z0-9]
        */

        //styles
        public readonly Style BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        public readonly Style BlueBoldStyle = new TextStyle(Brushes.Blue, null, FontStyle.Bold);
        public readonly Style BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        public readonly Style GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        public readonly Style MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        public readonly Style GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        public readonly Style BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        public readonly Style RedStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
        public readonly Style MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);

        public Style NormalTextStyle = new TextStyle(new SolidBrush(Color.FromArgb(248, 248, 242)), null, FontStyle.Regular);
        public Style KeywordTextStyle = new TextStyle(new SolidBrush(Color.FromArgb(249, 38, 114)), null, FontStyle.Regular);
        public Style ClassOrAttributeNameStyle = new TextStyle(new SolidBrush(Color.FromArgb(166, 226, 46)), null, FontStyle.Regular);
        public Style NumberTextStyle = new TextStyle(new SolidBrush(Color.FromArgb(174, 129, 255)), null, FontStyle.Regular);
        public Style CommentTextStyle = new TextStyle(new SolidBrush(Color.FromArgb(117, 113, 94)), null, FontStyle.Regular);


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


        Regex HTMLTagRegex, HTMLTagNameRegex, HTMLEndTagRegex, HTMLAttrRegex, HTMLAttrValRegex, HTMLCommentRegex1, HTMLCommentRegex2, HTMLEntityRegex, HTMLTagContentRegex;

        void InitHTMLRegex()
        {
            HTMLCommentRegex1 = new Regex(@"(<!--.*?-->)|(<!--.*)", RegexOptions.Singleline | RegexCompiledOption);
            HTMLCommentRegex2 = new Regex(@"(<!--.*?-->)|(.*-->)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexCompiledOption);
            HTMLTagRegex = new Regex(@"<|/>|</|>", RegexCompiledOption);
            HTMLTagNameRegex = new Regex(@"<(?<range>[!\w:]+)", RegexCompiledOption);
            HTMLEndTagRegex = new Regex(@"</(?<range>[\w:]+)>", RegexCompiledOption);
            HTMLTagContentRegex = new Regex(@"<[^>]+>", RegexCompiledOption);
            HTMLAttrRegex = new Regex(@"(?<range>[\w\d\-]{1,20}?)='[^']*'|(?<range>[\w\d\-]{1,20})=""[^""]*""|(?<range>[\w\d\-]{1,20})=[\w\d\-]{1,20}", RegexCompiledOption);
            HTMLAttrValRegex = new Regex(@"[\w\d\-]{1,20}?=(?<range>'[^']*')|[\w\d\-]{1,20}=(?<range>""[^""]*"")|[\w\d\-]{1,20}=(?<range>[\w\d\-]{1,20})", RegexCompiledOption);
            HTMLEntityRegex = new Regex(@"\&(amp|gt|lt|nbsp|quot|apos|copy|reg|#[0-9]{1,8}|#x[0-9a-f]{1,8});", RegexCompiledOption | RegexOptions.IgnoreCase);
        }

        private void HTMLAutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            FastColoredTextBox tb = sender as FastColoredTextBox;
            tb.CalcAutoIndentShiftByCodeFolding(sender, args);
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
        /// HTML tag name style
        /// </summary>
        public Style TagNameStyle { get; set; }
        /// <summary>
        /// HTML Entity style
        /// </summary>
        public Style HtmlEntityStyle { get; set; }

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
                case Language.HTML:
                    CommentStyle = CommentTextStyle;
                    TagBracketStyle = BlueStyle;
                    TagNameStyle = KeywordTextStyle;
                    AttributeStyle = ClassOrAttributeNameStyle;
                    AttributeValueStyle = BlueStyle;
                    HtmlEntityStyle = RedStyle;
                    NumberStyle = NumberTextStyle;
                    break;
                case Language.CSharp:
                    StringStyle = BrownStyle;
                    CommentStyle = GreenStyle;
                    NumberStyle = MagentaStyle;
                    AttributeStyle = GreenStyle;
                    ClassNameStyle = BoldStyle;
                    KeywordStyle = BlueStyle;
                    CommentTagStyle = GrayStyle;
                    break;
                case Language.VB:
                    StringStyle = BrownStyle;
                    CommentStyle = GreenStyle;
                    NumberStyle = MagentaStyle;
                    ClassNameStyle = BoldStyle;
                    KeywordStyle = BlueStyle;
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
                case Language.SQL:
                    StringStyle = RedStyle;
                    CommentStyle = GreenStyle;
                    NumberStyle = MagentaStyle;
                    KeywordStyle = BlueStyle;
                    StatementsStyle = BlueBoldStyle;
                    FunctionsStyle = MaroonStyle;
                    VariableStyle = MaroonStyle;
                    TypesStyle = BrownStyle;
                    break;
            }
        }


        /// <summary>
        /// Highlights HTML code
        /// </summary>
        /// <param name="range"></param>
        public virtual void HTMLSyntaxHighlight(Range range)
        {
            range.tb.CommentPrefix = null;
            range.tb.LeftBracket = '<';
            range.tb.RightBracket = '>';
            range.tb.LeftBracket2 = '(';
            range.tb.RightBracket2 = ')';
            //clear style of changed range
            range.ClearStyle(CommentStyle, TagBracketStyle, TagNameStyle, AttributeStyle, AttributeValueStyle, HtmlEntityStyle);
            //
            if (HTMLTagRegex == null)
                InitHTMLRegex();
            //comment highlighting
            range.SetStyle(CommentStyle, HTMLCommentRegex1);
            range.SetStyle(CommentStyle, HTMLCommentRegex2);
            //tag brackets highlighting
            range.SetStyle(TagBracketStyle, HTMLTagRegex);
            //tag name
            range.SetStyle(TagNameStyle, HTMLTagNameRegex);
            //end of tag
            range.SetStyle(TagNameStyle, HTMLEndTagRegex);
            //attributes
            range.SetStyle(AttributeStyle, HTMLAttrRegex);
            //attribute values
            range.SetStyle(AttributeValueStyle, HTMLAttrValRegex);
            //html entity
            range.SetStyle(HtmlEntityStyle, HTMLEntityRegex);

            //clear folding markers
            range.ClearFoldingMarkers();
            //set folding markers
            range.SetFoldingMarkers("<head", "</head>", RegexOptions.IgnoreCase);
            range.SetFoldingMarkers("<body", "</body>", RegexOptions.IgnoreCase);
            range.SetFoldingMarkers("<table", "</table>", RegexOptions.IgnoreCase);
            range.SetFoldingMarkers("<form", "</form>", RegexOptions.IgnoreCase);
            range.SetFoldingMarkers("<div", "</div>", RegexOptions.IgnoreCase);
            range.SetFoldingMarkers("<script", "</script>", RegexOptions.IgnoreCase);
            range.SetFoldingMarkers("<tr", "</tr>", RegexOptions.IgnoreCase);
        }
    }
}
