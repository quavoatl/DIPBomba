using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public class ChristmasTree : TreeBase
    {
        public ChristmasTree(string type) : base(type)
        {
        }

        public override string AddMessage()
        {
            return "A nice Christmas Tree!";
        }
    }
}
