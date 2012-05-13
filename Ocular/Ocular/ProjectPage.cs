using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;
namespace Ocular
{
    public partial class ProjectPage : Form
    {
        //Create style for highlighting
        TextStyle maroonStyle = new TextStyle(Brushes.DarkBlue, null, FontStyle.Regular);

        public ProjectPage()
        {
            InitializeComponent();
        }

        private void ProjectPage_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigating += new WebBrowserNavigatingEventHandler(webBrowser1_Navigating);
            webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(webBrowser1_Navigated);
            webBrowser1.Navigate("www.google.com");
        }

        void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            fastColoredTextBox1.Text = webBrowser1.DocumentText;
            FastColoredTextBoxNS.SyntaxHighlighter highlighter = new FastColoredTextBoxNS.SyntaxHighlighter();
            highlighter.HTMLSyntaxHighlight(new FastColoredTextBoxNS.Range(fastColoredTextBox1));
        }
        void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }

        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            //clear previous highlighting
            e.ChangedRange.ClearStyle(maroonStyle);
            //highlight tags
            e.ChangedRange.SetStyle(maroonStyle, "<[^>]+>");
            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.SetFoldingMarkers("<html>", "</html>");
            e.ChangedRange.SetFoldingMarkers("<head>", "</head>");
            e.ChangedRange.SetFoldingMarkers("<body>", "</body>");
            e.ChangedRange.SetFoldingMarkers("<p>", "</p>");
        }
    }
}
