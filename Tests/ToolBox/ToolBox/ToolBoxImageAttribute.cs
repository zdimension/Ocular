using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolBox
{
    public class ToolBoxImageAttribute : Attribute
    {
        public string ResourcePath { get; set; }
        public ToolBoxImageAttribute(string ResourcePath)
        {
            this.ResourcePath = ResourcePath;
        }
    }
}
