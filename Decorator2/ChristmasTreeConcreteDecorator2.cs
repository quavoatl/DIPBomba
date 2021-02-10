using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public class ChristmasTreeConcreteDecorator2 : ChristmasTreeDecoratorBase
    {
        public ChristmasTreeConcreteDecorator2(TreeBase tree) : base(tree)
        {
        }

        public override string AddMessage()
        {
            return base.AddMessage() + " cu so steaua an varf LOL";
        }
    }
}
