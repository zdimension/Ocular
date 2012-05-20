using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolBox
{
    public class ToolBoxCodeAttribute : Attribute
    {
        public string Code { get; set; }
        public ToolBoxCodeAttribute(string Code)
        {
            this.Code = Code;
        }
    }
}
