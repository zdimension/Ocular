using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ToolBox
{
    public static class Loader
    {
        public static List<ToolBoxItem> Load(string AssemblyPath)
        {
            Assembly a = Assembly.LoadFrom(AssemblyPath);
            List<ToolBoxItem> Items = new List<ToolBoxItem>();
            foreach (Type t in a.GetTypes())
            {
                object[] atts = null;
                ToolBoxItem item = new ToolBoxItem();
                if ((atts = t.GetCustomAttributes(typeof(ToolBoxTextAttribute), true)) != null)
                {
                    foreach (Attribute v in atts as Attribute[])
                    {
                        item.Text = (v as ToolBoxTextAttribute).Text;
                    }
                }
                if ((atts = t.GetCustomAttributes(typeof(ToolBoxCodeAttribute), true)) != null)
                {
                    foreach (Attribute v in atts as Attribute[])
                    {
                        item.Code = (v as ToolBoxCodeAttribute).Code;
                    }
                }
                if ((atts = t.GetCustomAttributes(typeof(ToolBoxImageAttribute), true)) != null)
                {
                    foreach (Attribute v in atts as Attribute[])
                    {
                        item.ImagePath = (v as ToolBoxImageAttribute).ResourcePath;
                    }
                }
            }
            return Items;
        }
    }
}
