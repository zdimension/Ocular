using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ocular
{
    class Tag
    {
        public string Name;
        public string tag;
        public string Description;

        public Tag(string name, string tag, string description)
        {
            this.Name = name;
            this.tag = tag;
            this.Description = description;
        }

        public Tag(string tag, string description)
            : this(tag, tag, description)
        {
        }
    }
}
