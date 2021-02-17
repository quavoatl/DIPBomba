using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public class ChristmasTreeConcreteDecorator1 : ChristmasTreeDecoratorBase
    {
        public ChristmasTreeConcreteDecorator1(TreeBase tree) : base(tree)
        {
        }

        public override string AddMessage()
        {
            return base.AddMessage() + " cu globuri misto belea O_O";
        }
    }
}
