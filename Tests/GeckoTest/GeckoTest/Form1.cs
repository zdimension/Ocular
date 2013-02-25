// A little research on how Gecko can be used in a C# project
// This, of course, gives only one way editing capability
// You write HTML and you can see the result
// Villanova is a Gecko wrapper, downloaded from http://www.devatan.tk/punbb/viewtopic.php?id=479
namespace GeckoTest
{
    using System;
    using System.Data;
    using System.Text;
    using System.Windows.Forms;
    using Skybound.Gecko;

    public partial class Form1 : Form
    {
        GeckoWebBrowser browser = new GeckoWebBrowser();
        private string path = "h.htm";
        
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("XulRunner");
            browser.CreateControl();            
            browser.Width = ClientRectangle.Width - EditPage.Width - 10;
            browser.Height = ClientRectangle.Height - 10;
            browser.Left = EditPage.Left + EditPage.Width + 2;
            browser.Top = 10;  
            browser.Parent = this;
            browser.Navigate("about:blank");            
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //Writing the html to disk file, so that I can navigate to it. 
            //I don't know if it is possible to navigate to in memory file
            System.IO.File.WriteAllText(path, EditPage.Text);
            string dynamicPath = "file:///" + Application.StartupPath + "/" + path;
            //a little hack. It seems Gecko doesn't like '#' char in filenames
            dynamicPath = dynamicPath.Replace("#", "%23");
            browser.Navigate(dynamicPath);
        }
    }
}
