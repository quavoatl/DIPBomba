using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public abstract class TreeBase
    {
        public TreeBase()
        {
            
        }

        protected TreeBase(string type)
        {
            Type = type;
        }

        public string Type { get; set; }
        public abstract string AddMessage();
    }
}
