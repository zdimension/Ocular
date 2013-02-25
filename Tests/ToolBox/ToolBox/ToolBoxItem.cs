using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolBox
{
    public class ToolBoxItem
    {
        public string Text { get; set; }
        public string ImagePath { get; set; }
        public string Code { get; set; }
        public ToolBoxItem()
        {
            this.Text = "ToolBoxItem";
            this.ImagePath = "";
            this.Code = "<ToolBoxItem></ToolBoxItem>";
        }
        public ToolBoxItem(string Text, string ImagePath, string Code)
        {
            this.Text = Text;
            this.ImagePath = ImagePath;
            this.Code = Code;
        }
    }
}
