using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Time = System.Timers;
using System.IO;
namespace Ocular
{
    public partial class DocumentWindow : Form
    {
        /// <summary>
        /// Creates a new HTML Editor window
        /// </summary>
        /// <param name="FileName">The file name of the HTML file</param>
        public DocumentWindow(string FileName)
        {
            filename = FileName;
            InitializeComponent();
        }
        public string FileName
        {
            get
            {
                return filename;
            }
        }
        string filename = string.Empty;
        private Time.Timer timer = new Time.Timer(5000);
        private void DocumentWindow_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Resources\\index.htm"))
            {
                PreviewControl.Navigate(Environment.CurrentDirectory + "\\Resources\\index.htm");
            }
            else
            {
                Ocular.Dialogs.Confirm conf = new Dialogs.Confirm("Ocular seems to be corrupt. Would you like to go to the Ocular site to download a new copy?");
                if (conf.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://ocular.codeplex.com");
                }
                else
                {
                    PreviewControl.Navigate("about:blank");
                }
            }
            timer.Elapsed += new Time.ElapsedEventHandler(timer_Elapsed);
        }

        void timer_Elapsed(object sender, Time.ElapsedEventArgs e)
        {
            timer.Stop();
            StatusText.Text = "Saving...";
            SourceCodeEditor.SaveToFile(FileName, Encoding.UTF8);
            StatusText.Text = "Loading...";
#warning Hack!
            PreviewControl.Url = new System.Uri(FileName);
            StatusText.Text = "Done";
            
        }

        private void SourceCodeEditor_Load(object sender, EventArgs e)
        {
           
        }

        private void SourceCodeEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            timer.Start();
        }


        private void PreviewControl_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
