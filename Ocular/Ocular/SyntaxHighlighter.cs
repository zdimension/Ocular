using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using FastColoredTextBoxNS;

namespace Ocular
{
    class SyntaxHighlighter : FastColoredTextBoxNS.SyntaxHighlighter
    {
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
        public readonly Style AspTagStyle = new TextStyle(Brushes.Black, Brushes.Yellow, FontStyle.Regular);
        //
        Dictionary<string, SyntaxDescriptor> descByXMLfileNames = new Dictionary<string, SyntaxDescriptor>();
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

        /// <summary>
        /// Highlights syntax for given language
        /// </summary>
        public virtual void HighlightSyntax(Language language, Range range)
        {
            switch (language)
            {
                case Language.VBSCRIPT: VBSyntaxHighlight(range); break;
                case Language.HTML: HTMLSyntaxHighlight(range); break;
                case Language.PHP: PHPSyntaxHighlight(range); break;
                case Language.JS: JScriptSyntaxHighlight(range); break;
                case Language.ASPNET: ASPNETSyntaxHighlight(range); break;
                default:
                    break;
            }
        }

        public virtual void AutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            FastColoredTextBox tb = (sender as FastColoredTextBox);
            Language language = Language.HTML;// = tb.Language;
            switch (tb.Language)
            {
                case FastColoredTextBoxNS.Language.HTML:
                    language = Language.HTML;
                    break;
                case FastColoredTextBoxNS.Language.JS:
                    language = Language.JS;
                    break;
                case FastColoredTextBoxNS.Language.PHP:
                    language = Language.PHP;
                    break;
                default:
                    break;
            }
            switch (language)
            {
                case Language.VBSCRIPT: VBAutoIndentNeeded(sender, args); break;
                case Language.HTML: HTMLAutoIndentNeeded(sender, args); break;
                case Language.PHP: PHPAutoIndentNeeded(sender, args); break;
                case Language.JS: JSAutoIndentNeeded(sender, args); break;//JS like C#
                default:
                    break;
            }
        }

        private void PHPAutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            /*
            FastColoredTextBox tb = sender as FastColoredTextBox;
            tb.CalcAutoIndentShiftByCodeFolding(sender, args);*/
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //is unclosed operator in previous line ?
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))//operator is unclosed
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }

       

        private void HTMLAutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            FastColoredTextBox tb = sender as FastColoredTextBox;
            //tb.CalcAutoIndentShiftByCodeFolding(sender, args);
        }

        private void VBAutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            //end of block
            if (Regex.IsMatch(args.LineText, @"^\s*(End|EndIf|Next|Loop)\b", RegexOptions.IgnoreCase))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //start of declaration
            if (Regex.IsMatch(args.LineText, @"\b(Class|Property|Enum|Structure|Sub|Function|Namespace|Interface|Get|Set)\b", RegexOptions.IgnoreCase))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            // then ...
            if (Regex.IsMatch(args.LineText, @"\b(Then)\s*\S+", RegexOptions.IgnoreCase))
                return;
            //start of operator block
            if (Regex.IsMatch(args.LineText, @"^\s*(If|While|For|Do|Try|With|Using|Select)\b", RegexOptions.IgnoreCase))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }

            //Statements else, elseif, case etc
            if (Regex.IsMatch(args.LineText, @"^\s*(Else|ElseIf|Case|Catch|Finally)\b", RegexOptions.IgnoreCase))
            {
                args.Shift = -args.TabLength;
                return;
            }

            //Char _
            if (args.PrevLineText.TrimEnd().EndsWith("_"))
            {
                args.Shift = args.TabLength;
                return;
            }
        }

        private void JSAutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //label
            if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
                !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
            {
                args.Shift = -args.TabLength;
                return;
            }
            //some statements: case, default
            if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
            {
                args.Shift = -args.TabLength / 2;
                return;
            }
            //is unclosed operator in previous line ?
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))//operator is unclosed
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }

        private static Color ParseColor(string s)
        {
            if (s.StartsWith("#"))
            {
                if (s.Length <= 7)
                    return Color.FromArgb(255, Color.FromArgb(Int32.Parse(s.Substring(1), System.Globalization.NumberStyles.AllowHexSpecifier)));
                else
                    return Color.FromArgb(Int32.Parse(s.Substring(1), System.Globalization.NumberStyles.AllowHexSpecifier));
            }
            else
                return Color.FromName(s);
        }

        public void HighlightSyntax(SyntaxDescriptor desc, Range range)
        {
            //set style order
            range.tb.ClearStylesBuffer();
            for (int i = 0; i < desc.styles.Count; i++)
                range.tb.Styles[i] = desc.styles[i];
            //brackets
            range.tb.LeftBracket = desc.leftBracket;
            range.tb.RightBracket = desc.rightBracket;
            range.tb.LeftBracket2 = desc.leftBracket2;
            range.tb.RightBracket2 = desc.rightBracket2;
            //clear styles of range
            range.ClearStyle(desc.styles.ToArray());
            //highlight syntax
            foreach (var rule in desc.rules)
                range.SetStyle(rule.style, rule.Regex);
            //clear folding
            range.ClearFoldingMarkers();
            //folding markers
            foreach (var folding in desc.foldings)
                range.SetFoldingMarkers(folding.startMarkerRegex, folding.finishMarkerRegex, folding.options);
        }

        Regex CSharpStringRegex, CSharpCommentRegex1, CSharpCommentRegex2, CSharpCommentRegex3, CSharpNumberRegex, CSharpAttributeRegex, CSharpClassNameRegex, CSharpKeywordRegex;

        void InitCShaprRegex()
        {
            CSharpStringRegex = new Regex(@"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'", RegexCompiledOption);
            CSharpCommentRegex1 = new Regex(@"//.*$", RegexOptions.Multiline | RegexCompiledOption);
            CSharpCommentRegex2 = new Regex(@"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline | RegexCompiledOption);
            CSharpCommentRegex3 = new Regex(@"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexCompiledOption);
            CSharpNumberRegex = new Regex(@"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b", RegexCompiledOption);
            CSharpAttributeRegex = new Regex(@"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline | RegexCompiledOption);
            CSharpClassNameRegex = new Regex(@"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b", RegexCompiledOption);
            CSharpKeywordRegex = new Regex(@"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b", RegexCompiledOption);
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


        #region VB Syntax Highlight
        Regex VBStringRegex, VBCommentRegex, VBNumberRegex, VBClassNameRegex, VBKeywordRegex;

        void InitVBRegex()
        {
            VBStringRegex = new Regex(@"""""|"".*?[^\\]""", RegexCompiledOption);
            VBCommentRegex = new Regex(@"'.*$", RegexOptions.Multiline | RegexCompiledOption);
            VBNumberRegex = new Regex(@"\b\d+[\.]?\d*([eE]\-?\d+)?\b", RegexCompiledOption);
            VBClassNameRegex = new Regex(@"\b(Class|Structure|Enum|Interface)[ ]+(?<range>\w+?)\b", RegexOptions.IgnoreCase | RegexCompiledOption);
            VBKeywordRegex = new Regex(@"\b(AddHandler|AddressOf|Alias|And|AndAlso|As|Boolean|ByRef|Byte|ByVal|Call|Case|Catch|CBool|CByte|CChar|CDate|CDbl|CDec|Char|CInt|Class|CLng|CObj|Const|Continue|CSByte|CShort|CSng|CStr|CType|CUInt|CULng|CUShort|Date|Decimal|Declare|Default|Delegate|Dim|DirectCast|Do|Double|Each|Else|ElseIf|End|EndIf|Enum|Erase|Error|Event|Exit|False|Finally|For|Friend|Function|Get|GetType|GetXMLNamespace|Global|GoSub|GoTo|Handles|If|Implements|Imports|In|Inherits|Integer|Interface|Is|IsNot|Let|Lib|Like|Long|Loop|Me|Mod|Module|MustInherit|MustOverride|MyBase|MyClass|Namespace|Narrowing|New|Next|Not|Nothing|NotInheritable|NotOverridable|Object|Of|On|Operator|Option|Optional|Or|OrElse|Overloads|Overridable|Overrides|ParamArray|Partial|Private|Property|Protected|Public|RaiseEvent|ReadOnly|ReDim|REM|RemoveHandler|Resume|Return|SByte|Select|Set|Shadows|Shared|Short|Single|Static|Step|Stop|String|Structure|Sub|SyncLock|Then|Throw|To|True|Try|TryCast|TypeOf|UInteger|ULong|UShort|Using|Variant|Wend|When|While|Widening|With|WithEvents|WriteOnly|Xor|Region)\b|(#Const|#Else|#ElseIf|#End|#If|#Region)\b", RegexOptions.IgnoreCase | RegexCompiledOption);
        }

        /// <summary>
        /// Highlights VB code
        /// </summary>
        /// <param name="range"></param>
        public virtual void VBSyntaxHighlight(Range range)
        {
            range.tb.CommentPrefix = "'";
            range.tb.LeftBracket = '(';
            range.tb.RightBracket = ')';
            range.tb.LeftBracket2 = '\x0';
            range.tb.RightBracket2 = '\x0';
            //clear style of changed range
            range.ClearStyle(StringStyle, CommentStyle, NumberStyle, ClassNameStyle, KeywordStyle);
            //
            if (VBStringRegex == null)
                InitVBRegex();
            //string highlighting
            range.SetStyle(StringStyle, VBStringRegex);
            //comment highlighting
            range.SetStyle(CommentStyle, VBCommentRegex);
            //number highlighting
            range.SetStyle(NumberStyle, VBNumberRegex);
            //class name highlighting
            range.SetStyle(ClassNameStyle, VBClassNameRegex);
            //keyword highlighting
            range.SetStyle(KeywordStyle, VBKeywordRegex);

            //clear folding markers
            range.ClearFoldingMarkers();
            //set folding markers
            range.SetFoldingMarkers(@"#Region\b", @"#End\s+Region\b", RegexOptions.IgnoreCase);
            range.SetFoldingMarkers(@"\b(Class|Property|Enum|Structure|Interface)[ \t]+\S+", @"\bEnd (Class|Property|Enum|Structure|Interface)\b", RegexOptions.IgnoreCase);
            range.SetFoldingMarkers(@"^\s*(?<range>While)[ \t]+\S+", @"^\s*(?<range>End While)\b", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            range.SetFoldingMarkers(@"\b(Sub|Function)[ \t]+[^\s']+", @"\bEnd (Sub|Function)\b", RegexOptions.IgnoreCase);//this declared separately because Sub and Function can be unclosed
            range.SetFoldingMarkers(@"(\r|\n|^)[ \t]*(?<range>Get|Set)[ \t]*(\r|\n|$)", @"\bEnd (Get|Set)\b", RegexOptions.IgnoreCase);
            range.SetFoldingMarkers(@"^\s*(?<range>For|For\s+Each)\b", @"^\s*(?<range>Next)\b", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            range.SetFoldingMarkers(@"^\s*(?<range>Do)\b", @"^\s*(?<range>Loop)\b", RegexOptions.Multiline | RegexOptions.IgnoreCase);
        }
        #endregion

        #region HTML Syntax Highlight
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
        #endregion

        #region PHP Syntax Highlight
        Regex PHPStringRegex, PHPNumberRegex, PHPCommentRegex1, PHPCommentRegex2, PHPCommentRegex3, PHPVarRegex, PHPKeywordRegex1, PHPKeywordRegex2, PHPKeywordRegex3;

        void InitPHPRegex()
        {
            PHPStringRegex = new Regex(@"""""|''|"".*?[^\\]""|'.*?[^\\]'", RegexCompiledOption);
            PHPNumberRegex = new Regex(@"\b\d+[\.]?\d*\b", RegexCompiledOption);
            PHPCommentRegex1 = new Regex(@"(//|#).*$", RegexOptions.Multiline | RegexCompiledOption);
            PHPCommentRegex2 = new Regex(@"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline | RegexCompiledOption);
            PHPCommentRegex3 = new Regex(@"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexCompiledOption);
            PHPVarRegex = new Regex(@"\$[a-zA-Z_\d]*\b", RegexCompiledOption);
            PHPKeywordRegex1 = new Regex(@"\b(die|echo|empty|exit|eval|include|include_once|isset|list|require|require_once|return|print|unset)\b", RegexCompiledOption);
            PHPKeywordRegex2 = new Regex(@"\b(abstract|and|array|as|break|case|catch|cfunction|class|clone|const|continue|declare|default|do|else|elseif|enddeclare|endfor|endforeach|endif|endswitch|endwhile|extends|final|for|foreach|function|global|goto|if|implements|instanceof|interface|namespace|new|or|private|protected|public|static|switch|throw|try|use|var|while|xor)\b", RegexCompiledOption);
            PHPKeywordRegex3 = new Regex(@"__CLASS__|__DIR__|__FILE__|__LINE__|__FUNCTION__|__METHOD__|__NAMESPACE__", RegexCompiledOption);
        }

        /// <summary>
        /// Highlights PHP code
        /// </summary>
        /// <param name="range"></param>
        public virtual void PHPSyntaxHighlight(Range range)
        {
            range.tb.CommentPrefix = "#";
            range.tb.LeftBracket = '(';
            range.tb.RightBracket = ')';
            range.tb.LeftBracket2 = '\x0';
            range.tb.RightBracket2 = '\x0';
            //clear style of changed range
            range.ClearStyle(StringStyle, CommentStyle, NumberStyle, VariableStyle, KeywordStyle, KeywordStyle2, KeywordStyle3);
            //
            if (PHPStringRegex == null)
                InitPHPRegex();
            //string highlighting
            range.SetStyle(StringStyle, PHPStringRegex);
            //comment highlighting
            range.SetStyle(CommentStyle, PHPCommentRegex1);
            range.SetStyle(CommentStyle, PHPCommentRegex2);
            range.SetStyle(CommentStyle, PHPCommentRegex3);
            //number highlighting
            range.SetStyle(NumberStyle, PHPNumberRegex);
            //var highlighting
            range.SetStyle(VariableStyle, PHPVarRegex);
            //keyword highlighting
            range.SetStyle(KeywordStyle, PHPKeywordRegex1);
            range.SetStyle(KeywordStyle2, PHPKeywordRegex2);
            range.SetStyle(KeywordStyle3, PHPKeywordRegex3);

            //clear folding markers
            range.ClearFoldingMarkers();
            //set folding markers
            range.SetFoldingMarkers("{", "}");//allow to collapse brackets block
            range.SetFoldingMarkers(@"/\*", @"\*/");//allow to collapse comment block
        }
        #endregion

        #region JScript Syntax Highlight
        Regex JScriptStringRegex, JScriptCommentRegex1, JScriptCommentRegex2, JScriptCommentRegex3, JScriptNumberRegex, JScriptKeywordRegex;

        void InitJScriptRegex()
        {
            JScriptStringRegex = new Regex(@"""""|''|"".*?[^\\]""|'.*?[^\\]'", RegexCompiledOption);
            JScriptCommentRegex1 = new Regex(@"//.*$", RegexOptions.Multiline | RegexCompiledOption);
            JScriptCommentRegex2 = new Regex(@"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline | RegexCompiledOption);
            JScriptCommentRegex3 = new Regex(@"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft | RegexCompiledOption);
            JScriptNumberRegex = new Regex(@"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b", RegexCompiledOption);
            JScriptKeywordRegex = new Regex(@"\b(true|false|break|case|catch|const|continue|default|delete|do|else|export|for|function|if|in|instanceof|new|null|return|switch|this|throw|try|var|void|while|with|typeof)\b", RegexCompiledOption);
        }

        /// <summary>
        /// Highlights JavaScript code
        /// </summary>
        /// <param name="range"></param>
        public virtual void JScriptSyntaxHighlight(Range range)
        {
            range.tb.CommentPrefix = "//";
            range.tb.LeftBracket = '(';
            range.tb.RightBracket = ')';
            range.tb.LeftBracket2 = '\x0';
            range.tb.RightBracket2 = '\x0';
            //clear style of changed range
            range.ClearStyle(StringStyle, CommentStyle, NumberStyle, KeywordStyle);
            //
            if (JScriptStringRegex == null)
                InitJScriptRegex();
            //string highlighting
            range.SetStyle(StringStyle, JScriptStringRegex);
            //comment highlighting
            range.SetStyle(CommentStyle, JScriptCommentRegex1);
            range.SetStyle(CommentStyle, JScriptCommentRegex2);
            range.SetStyle(CommentStyle, JScriptCommentRegex3);
            //number highlighting
            range.SetStyle(NumberStyle, JScriptNumberRegex);
            //keyword highlighting
            range.SetStyle(KeywordStyle, JScriptKeywordRegex);
            //clear folding markers
            range.ClearFoldingMarkers();
            //set folding markers
            range.SetFoldingMarkers("{", "}");//allow to collapse brackets block
            range.SetFoldingMarkers(@"/\*", @"\*/");//allow to collapse comment block
        }
        #endregion

        #region ASP.NET Syntax Highlight
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

        /// <summary>
        /// Highlights ASPNET code
        /// </summary>
        /// <param name="range"></param>
        public virtual void ASPNETSyntaxHighlight(Range range)
        {
            range.tb.CommentPrefix = null;
            range.tb.LeftBracket = '<';
            range.tb.RightBracket = '>';
            range.tb.LeftBracket2 = '(';
            range.tb.RightBracket2 = ')';
            //clear style of changed range
            range.ClearStyle(CommentStyle, TagBracketStyle, TagNameStyle, AttributeStyle, AttributeValueStyle, ASPNETEntityStyle);
            //
            if (ASPNETTagRegex == null)
                InitASPNETRegex();
            //comment highlighting
            range.SetStyle(CommentStyle, ASPNETCommentRegex1);
            range.SetStyle(CommentStyle, ASPNETCommentRegex2);
            //tag brackets highlighting
            range.SetStyle(TagBracketStyle, ASPNETTagRegex);
            // '<%' tag brackets highlighting
            range.SetStyle(SpTagBracketStyle, ASPNETSpTagRegex);
            //tag name
            range.SetStyle(TagNameStyle, ASPNETTagNameRegex);
            //end of tag
            range.SetStyle(TagNameStyle, ASPNETEndTagRegex);
            //attributes
            range.SetStyle(AttributeStyle, ASPNETAttrRegex);
            //attribute values
            range.SetStyle(AttributeValueStyle, ASPNETAttrValRegex);
            //ASPNET entity
            range.SetStyle(ASPNETEntityStyle, ASPNETEntityRegex);

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
        #endregion

        public void Dispose()
        {
            foreach (var desc in descByXMLfileNames.Values)
                desc.Dispose();
        }

    }
}
