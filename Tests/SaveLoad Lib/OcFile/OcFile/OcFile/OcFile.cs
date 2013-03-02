using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
namespace Ocular
{
    public class FileLoader
    {
        /* Brief description of format:
         * A folder is created by Ocular with all the HTML files and whatever
         * When saved, an .ocproj file is created, which is a valid XML file that has the magic code of Ocular, and basic metadata.
         * When loading, the loader returns a ProjectData class that gives Ocular the information needed to load properly.
         */
        #region FileData
        public class FileData
        {
            public FileData(string _projname, string _ocularversion, bool valid)
            {
                projname = _projname;
                version = _ocularversion;
                isvalid = valid;
            }
            bool isvalid;
            public bool IsValid
            {
                get
                {
                    return isvalid;
                }
            }
            string projname;
            /// <summary>
            /// The path (guaranteed to be the full path)
            /// </summary>
            public string ProjectName
            {
                get
                {
                    return projname;
                }
            }
            string version;
            /// <summary>
            /// The version of Ocular this project was created with. Comes in the format major.minor.revision.status
            /// Status can be pre (prealpha), alpha, beta, rel (release)
            /// </summary>
            public string Version
            {
                get
                {
                    return version;
                }
            }
            /// <summary>
            /// Returns only the major version. If the file format is invalid and the major is not a number, -1 is returned.
            /// </summary>
            public int MajorVersion
            {
                get
                {
                    try
                    {
                        return Int32.Parse(version.Split('.')[0]);
                    }
                    catch
                    {
                        return -1;
                    }
                }
            }
            /// <summary>
            /// Returns only the minor version. If the file format is invalid and the minor is not a number, -1 is returned.
            /// </summary>
            public int MinorVersion
            {
                get
                {
                    try
                    {
                        return Int32.Parse(version.Split('.')[1]);
                    }
                    catch
                    {
                        return -1;
                    }
                }
            }
            /// <summary>
            /// Returns only the revision. If the file format is invalid and the revision is not a number, -1 is returned.
            /// </summary>
            public int RevisionVersion
            {
                get
                {
                    try
                    {
                        return Int32.Parse(version.Split('.')[2]);
                    }
                    catch
                    {
                        return -1;
                    }
                }
            }
            /// <summary>
            /// Returns the release string, or unk if there is an error.
            /// Possibilities:
            /// unk (unknown), pre (prealpha), alpha, beta, rel (release)
            /// </summary>
            public string ReleaseString
            {
                get
                {
                    try
                    {
                        return version.Split('.')[3];
                    }
                    catch
                    {
                        return "unk";
                    }
                }
            }
        }
        #endregion
        string _path;
        public string Path
        {
            get
            {
                return System.IO.Path.GetFullPath(_path);
            }
        }
        public FileLoader(string path)
        {
            _path = path;
            System.Diagnostics.Debug.WriteLine(path);
        }
        public FileData Execute()
        {
            string projectname = string.Empty;
            string version = string.Empty;
            //Check if the path provided really is an Ocular project
            string[] dirs = Directory.GetFiles(Path, "*.ocproj");
            if (dirs.Length > 0)
            {
                //If there is more than one ocproj file, the first will be chosen no matter what. Maybe this should be changed?
                using (XmlReader reader = XmlReader.Create(dirs[0]))
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                if (reader.Name == "ProjectName")
                                {
                                    projectname = reader.ReadString();
                                    System.Diagnostics.Debug.WriteLine("Found ProjectName");
                                }
                                else if (reader.Name == "OcularVersion")
                                {
                                    version = reader.ReadString();
                                    System.Diagnostics.Debug.WriteLine("Found OcularVersion");
                                }
                                break;
                        }
                    }
                }
                if (projectname == string.Empty || version == string.Empty)
                {
                    System.Diagnostics.Debug.WriteLine("An element is still empty.");
                    FileData data = new FileData("", "", false);
                    return data;
                }
                FileData thisdata = new FileData(projectname,version,true);
                return thisdata;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No .ocproj found.");
                FileData data = new FileData("", "", false);
                return data;
            }
        }
    }
    public class FileSaver
    {
        #region Variables and Properties
        string _projectpath;
        public string ProjectPath
        {
            get
            {
                return _projectpath;
            }
        }
        string _projectname;
        public string ProjectName
        {
            get
            {
                return _projectname;
            }
        }
        string _versionstring;
        public string VersionString
        {
            get
            {
                return _versionstring;
            }
        }
        #endregion
        public FileSaver(string path, string projectname, string ocularversionstring)
        {
            _projectpath = Path.GetFullPath(path);
            _projectname = projectname;
            _versionstring = ocularversionstring;
            GenerateXML();
        }
        void GenerateXML()
        {
            System.Diagnostics.Debug.WriteLine("Creating XML file at: " + _projectpath + "\\" + _projectname + ".ocproj");
            using (XmlWriter writer = XmlWriter.Create(_projectpath + "\\" + _projectname + ".ocproj"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("OcularProject");
                writer.WriteElementString("ProjectName", _projectname);
                writer.WriteElementString("OcularVersion", _versionstring);
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
