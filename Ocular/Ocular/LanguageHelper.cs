using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastColoredTextBoxNS;
using System.Reflection;

namespace Ocular
{
    class LanguageHelper
    {
        public static string BasicHTMLPage()
        {
            string s = 
@"<!DOCTYPE html>
<html>
    <head>
    </head>
    <body>
    </body>
</html>
";
            return s;
        }

        AutocompleteMenu autocomp;

        public List<Tag> Tags = new List<Tag>();

        public LanguageHelper()
        {
            /*Type t = typeof(HTMLTags);
            List<FieldInfo> f = t.GetFields().ToList();

            foreach (FieldInfo fi in f)
            {
                Type abc = fi.GetType();
                //Tag tag = (Tag)Activator.CreateInstance(fi.GetType());
                string nm = (string)(fi.GetValue("Name"));
                string desc = (string)(fi.GetValue("Description"));
                string tghi = "";
                Tag tag = new Tag(nm, desc);
                //Tag tag = (Tag)(abc.GetConstructor(new Type[] { }).Invoke(new object[] { }));

                Tags.Add(tag);
            }

            //Tags.Add(HTMLTags.a);
            //Tags.Add(HTMLTags.abbr);*/
        }
    }
}
