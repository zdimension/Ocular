using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using tar_cs;
using System.Xml;
namespace Ocular
{
    /// <summary>
    /// This class has utilites for saving and loading ocproj files.
    /// </summary>
    public class FileManagement
    {
        public class FileData
        {
            public string ProjectName;

            public string DefaultPage;
        }
        public class ReadHelper
        {
            FileData data = new FileData();
            string location;
            string destination;
            /// <summary>
            /// Creates an instance of the ReadHelper. THIS DOES NOT INVOKE THE READHELPER, YOU MUST CALL THE RUN CLASS FOR THIS!
            /// </summary>
            /// <param name="FileLocation"></param>
            /// <param name="Destination"></param>
            public ReadHelper(string FileLocation, string Destination)
            {
                location = FileLocation;
                destination = Destination;
            }
            /// <summary>
            /// Reads a .ocproj file. 
            /// </summary>
            /// <returns>Throws an exception if there's an error, data if true.</returns>
            public FileData Run()
            {
                using (FileStream tarloc = File.Open(Path.GetFullPath(location), FileMode.Open))
                {
                    TarReader untar = new TarReader(tarloc);
                    untar.ReadToEnd(Path.GetFullPath(destination));
                }
                string loc = Directory.GetDirectories(destination)[0];
                using (XmlReader reader = XmlReader.Create(loc + "\\index.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Value == "Name")
                            {
                                data.ProjectName = reader.ReadSubtree().Value;
                            }
                            else if (reader.Value == "Magic")
                            {
                                if (reader.ReadSubtree().Value != "AuthenticOcularProject")
                                {
                                    //Corrupt...
                                    throw new InvalidDataException("The file is corrupt.");
                                }
                            }
                        }
                    }
                }
                return data;
            }
           
        }
        public class SaveHelper
        {
            string PathToProjectFolder;
            string PathToNewProject;
            FileData data = new FileData();
            /// <summary>
            /// Creates an instance of the SaveHelper
            /// </summary>
            public SaveHelper(string location, string destination, FileData filedata)
            {
                PathToProjectFolder = location;
                PathToNewProject = destination;
                data = filedata;
            }
            public void Save()
            {
                //First, we will prepare the folder for adding as a project...
                using (XmlWriter writer = XmlWriter.Create(Path.GetFullPath(PathToProjectFolder) + "\\index.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Project");
                    writer.WriteElementString("Name", data.ProjectName);
                    writer.WriteElementString("Magic", "AuthenticOcularProject");
                    writer.WriteElementString("DefaultPage", data.DefaultPage);
                    writer.WriteEndDocument();
                }
             

                using (FileStream tarLocation = File.Create(Path.GetFullPath(PathToNewProject)))
                {
                    using (TarWriter TarHelper = new TarWriter(tarLocation))
                    {

                        foreach (string file in System.IO.Directory.GetFiles(PathToProjectFolder))
                        {
                            System.Diagnostics.Debug.WriteLine(file + " written to tar archive.");
                            TarHelper.Write(file);
                        }
                        TarHelper.Close();
                    }
                }

            }

        }
    }
}
