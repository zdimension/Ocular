using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolBox;
using ToolBoxItemTest;
using System.Reflection;

namespace RunTest
{
    class Program
    {
        /*IEnumerable<List<ToolBoxTextAttribute[]>> res = from t in Assembly.LoadFrom("ToolBoxItemTest.dll").GetTypes() select (from b in new Type[] { t } select (from q in b.GetCustomAttributes(true) where q is Attribute && (q as Attribute) is ToolBoxTextAttribute select q as ToolBoxTextAttribute) as ToolBoxTextAttribute[]) as List<ToolBoxTextAttribute[]>;
            IEnumerable<List<ToolBoxCodeAttribute[]>> re = from t in Assembly.LoadFrom("ToolBoxItemTest.dll").GetTypes() select (from b in new Type[]{t} select (from q in b.GetCustomAttributes(true) where q is Attribute && (q as Attribute) is ToolBoxCodeAttribute select q as ToolBoxCodeAttribute) as ToolBoxCodeAttribute[]) as List<ToolBoxCodeAttribute[]>;
            IEnumerable<List<ToolBoxImageAttribute[]>> r = from t in Assembly.LoadFrom("ToolBoxItemTest.dll").GetTypes() select (from b in new Type[] { t } select (from q in b.GetCustomAttributes(true) where q is Attribute && (q as Attribute) is ToolBoxImageAttribute select q as ToolBoxImageAttribute) as ToolBoxImageAttribute[]) as List<ToolBoxImageAttribute[]>;
            
            List<ToolBoxItem> ToolBoxItems = new List<ToolBoxItem>();

            List<ToolBoxTextAttribute[]> resl = new List<ToolBoxTextAttribute[]>();
            List<ToolBoxCodeAttribute[]> rel = new List<ToolBoxCodeAttribute[]>();
            List<ToolBoxImageAttribute[]> rl = new List<ToolBoxImageAttribute[]>();
            foreach (List<ToolBoxTextAttribute[]> l in res)
                resl = l;
            foreach (List<ToolBoxCodeAttribute[]> l in re)
                rel = l; 
            foreach (List<ToolBoxImageAttribute[]> l in r)
                rl = l;
            int i = 0;
            string g = "";
            foreach (ToolBoxTextAttribute[] arr in resl)
            {
                int cd = 0;
                foreach (ToolBoxTextAttribute att in arr)
                {
                    ToolBoxItems.Add(new ToolBoxItem(att.Text, rl[i][cd].ResourcePath, rel[i][cd].Code));
                    cd++;
                }
                i++;
            }
            string a = "";
            Console.Read();*/
        static void Main(string[] args)
        {
            Assembly a = Assembly.LoadFrom("ToolBoxItemTest.dll");
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
        }
    }
}
