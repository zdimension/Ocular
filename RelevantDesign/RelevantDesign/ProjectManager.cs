using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace RelevantDesign
{
    public class ProjectManager
    {
        public string ProjectDirectory { get; set; }
        public ProjectManager(string projectdir)
        {
            this.ProjectDirectory = projectdir + @"\";
        }
        public bool CreateNew(string name)
        {
            if (Directory.Exists(this.ProjectDirectory + name))
                MessageBox.Show("Project with same name already exists!");
            else
            {
                Directory.CreateDirectory(this.ProjectDirectory + name);
                XmlDocument doc = new XmlDocument();
                doc.CreateXmlDeclaration("1.0", "utf-8", "");
                XmlNode nod = doc.CreateElement("Project");
                XmlAttribute att = doc.CreateAttribute("Name");
                att.Value = name;
                
                XmlNode date = doc.CreateElement("CreationDate");
                date.InnerText = DateTime.Now.ToString();
                XmlNode files = doc.CreateElement("Files");
                Directory.CreateDirectory(this.ProjectDirectory + "\\" + name + "\\Files");
                StreamWriter sw = new StreamWriter(this.ProjectDirectory + "\\" + name + "\\Files\\Index.html");
                sw.WriteLine("<html>");
                sw.WriteLine("  <head>");
                sw.WriteLine("      ");
                sw.WriteLine("  </head>");
                sw.WriteLine("  <body>");
                sw.WriteLine("      ");
                sw.WriteLine("  </body>");
                sw.WriteLine("</html>");
                sw.Close();
                XmlNode index = doc.CreateElement("File");
                index.InnerText = "Index.html";
                files.AppendChild(index);

                nod.Attributes.Append(att);
                nod.AppendChild(date);
                nod.AppendChild(files);
                doc.AppendChild(nod);

                doc.Save(this.ProjectDirectory + name + "\\" + name + ".ocproj");
                return true;
            }
            return false;
        }
    }
}
