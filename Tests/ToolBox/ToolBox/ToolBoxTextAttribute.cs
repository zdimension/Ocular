using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolBox
{
    public class ToolBoxTextAttribute : Attribute
    {
        public string Text { get; set; }
        public ToolBoxTextAttribute(string Text)
        {
            this.Text = Text;
        }
    }
}
