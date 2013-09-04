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
            }*/

            
            Tags.Add(HTMLTags.a);
            Tags.Add(HTMLTags.abbr);
            Tags.Add(HTMLTags.address);
            Tags.Add(HTMLTags.area);
            Tags.Add(HTMLTags.article);
            Tags.Add(HTMLTags.aside);
            Tags.Add(HTMLTags.audio);
            Tags.Add(HTMLTags.b);
            Tags.Add(HTMLTags.@base);
            Tags.Add(HTMLTags.bdi);
            Tags.Add(HTMLTags.bdo);
            Tags.Add(HTMLTags.blockquote);
            Tags.Add(HTMLTags.body);
            Tags.Add(HTMLTags.br);
            Tags.Add(HTMLTags.button);
            Tags.Add(HTMLTags.canvas);
            Tags.Add(HTMLTags.caption);
            Tags.Add(HTMLTags.cite);
            Tags.Add(HTMLTags.code);
            Tags.Add(HTMLTags.col);
            Tags.Add(HTMLTags.colgroup);
            Tags.Add(HTMLTags.command);
            Tags.Add(HTMLTags.datalist);
            Tags.Add(HTMLTags.dd);
            Tags.Add(HTMLTags.del);
            Tags.Add(HTMLTags.details);
            Tags.Add(HTMLTags.dfn);
            Tags.Add(HTMLTags.dialog);
            Tags.Add(HTMLTags.div);
            Tags.Add(HTMLTags.dl);
            Tags.Add(HTMLTags.doctype);
            Tags.Add(HTMLTags.dt);
            Tags.Add(HTMLTags.em);
            Tags.Add(HTMLTags.embed);
            Tags.Add(HTMLTags.fieldset);
            Tags.Add(HTMLTags.figcaption);
            Tags.Add(HTMLTags.figure);
            Tags.Add(HTMLTags.footer);
            Tags.Add(HTMLTags.form);
            Tags.Add(HTMLTags.h1);
            Tags.Add(HTMLTags.h2);
            Tags.Add(HTMLTags.h3);
            Tags.Add(HTMLTags.h4);
            Tags.Add(HTMLTags.h5);
            Tags.Add(HTMLTags.h6);
            Tags.Add(HTMLTags.head);
            Tags.Add(HTMLTags.header);
            Tags.Add(HTMLTags.hr);
            Tags.Add(HTMLTags.html);
            Tags.Add(HTMLTags.i);
            Tags.Add(HTMLTags.iframe);
            Tags.Add(HTMLTags.img);
            Tags.Add(HTMLTags.input);
            Tags.Add(HTMLTags.ins);
            Tags.Add(HTMLTags.kbd);
            Tags.Add(HTMLTags.keygen);
            Tags.Add(HTMLTags.label);
            Tags.Add(HTMLTags.legend);
            Tags.Add(HTMLTags.li);
            Tags.Add(HTMLTags.link);
            Tags.Add(HTMLTags.map);
            Tags.Add(HTMLTags.mark);
            Tags.Add(HTMLTags.menu);
            Tags.Add(HTMLTags.meta);
            Tags.Add(HTMLTags.meter);
            Tags.Add(HTMLTags.nav);
            Tags.Add(HTMLTags.noscript);
            Tags.Add(HTMLTags.@object);
            Tags.Add(HTMLTags.ol);
            Tags.Add(HTMLTags.optgroup);
            Tags.Add(HTMLTags.option);
            Tags.Add(HTMLTags.output);
            Tags.Add(HTMLTags.p);
            Tags.Add(HTMLTags.param);
            Tags.Add(HTMLTags.pre);
            Tags.Add(HTMLTags.progress);
            Tags.Add(HTMLTags.q);
            Tags.Add(HTMLTags.rp);
            Tags.Add(HTMLTags.rt);
            Tags.Add(HTMLTags.ruby);
            Tags.Add(HTMLTags.s);
            Tags.Add(HTMLTags.samp);
            Tags.Add(HTMLTags.script);
            Tags.Add(HTMLTags.section);
            Tags.Add(HTMLTags.select);
            Tags.Add(HTMLTags.small);
            Tags.Add(HTMLTags.source);
            Tags.Add(HTMLTags.span);
            Tags.Add(HTMLTags.strong);
            Tags.Add(HTMLTags.style);
            Tags.Add(HTMLTags.sub);
            Tags.Add(HTMLTags.summary);
            Tags.Add(HTMLTags.sup);
            Tags.Add(HTMLTags.table);
            Tags.Add(HTMLTags.tbody);
            Tags.Add(HTMLTags.td);
            Tags.Add(HTMLTags.textarea);
            Tags.Add(HTMLTags.tfoot);
            Tags.Add(HTMLTags.th);
            Tags.Add(HTMLTags.thead);
            Tags.Add(HTMLTags.time);
            Tags.Add(HTMLTags.title);
            Tags.Add(HTMLTags.tr);
            Tags.Add(HTMLTags.track);
            Tags.Add(HTMLTags.u);
            Tags.Add(HTMLTags.ul);
            Tags.Add(HTMLTags.var);
            Tags.Add(HTMLTags.video);
            Tags.Add(HTMLTags.wbr);
        }
    }
}
