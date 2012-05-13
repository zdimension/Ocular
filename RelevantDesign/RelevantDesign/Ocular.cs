using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace RelevantDesign
{
    public partial class Ocular : Form
    {
        private TabPage WP;
        private ProjectManager Manager;
        public string InitDirectory { get; set; }
        public Ocular()
        {
            this.InitDirectory = @"C:\Ocular";
            this.Manager = new ProjectManager(this.InitDirectory + "\\Projects");
            InitializeComponent();
        }
        public void VerifyDirectories()
        {
            if (!Directory.Exists(this.InitDirectory))
                Directory.CreateDirectory(this.InitDirectory);
            if (!Directory.Exists(this.InitDirectory + "\\Projects"))
                Directory.CreateDirectory(this.InitDirectory + "\\Projects");
        }
        private void Ocular_Load(object sender, EventArgs e)
        {
            this.VerifyDirectories();
            this.Welcome();
        }
        public void Welcome()
        {
            this.WorkingTab.TabPages.Add("Welcome");
            WebBrowser browser = new WebBrowser();
            browser.Navigate("http://ocular.codeplex.com");
            browser.Dock = DockStyle.Fill;
            this.WorkingTab.TabPages[this.WorkingTab.TabPages.Count - 1].Controls.Add(browser);
        }
        public void AddProject()
        {
            string projectName = Microsoft.VisualBasic.Interaction.InputBox("Please type project name", "Create new Project", "OcularProject1");
            if (this.Manager.CreateNew(projectName))
            {
                this.CreateFileWorkspace("Index.html", this.Manager.ProjectDirectory + projectName + "\\Files\\Index.html");
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddProject();
        }
        public void CreateFileWorkspace(string file, string fulladdress)
        {
            TabPage page = new TabPage(file);
            RichTextBox box = new RichTextBox();
            box.Text = System.IO.File.ReadAllText(fulladdress);
            box.Dock = DockStyle.Fill;
            page.Controls.Add(box);

            TabPage p = new TabPage(file + " [View]");
            WebBrowser browser = new WebBrowser();
            browser.Navigate(fulladdress);
            browser.Dock = DockStyle.Fill;
            p.Controls.Add(browser);

            this.WorkingTab.TabPages.Add(page);
            this.WorkingTab.TabPages.Add(p);
            this.WorkingTab.SelectTab(page);
        }
    }
}
