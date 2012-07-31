using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Ocular
{
    public partial class DocumentWindow : Form
    {
        public DocumentWindow()
        {
            InitializeComponent();
        }

        private void DocumentWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void SourceCodeEditor_Load(object sender, EventArgs e)
        {

        }

        private void SourceCodeEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            PreviewControl.Navigate("about:blank");
            PreviewControl.DocumentText = SourceCodeEditor.Text;
        }
    }
}
