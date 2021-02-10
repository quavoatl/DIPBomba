using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public abstract class ChristmasTreeDecoratorBase : TreeBase
    {
        private TreeBase _treeBase = null;
        protected ChristmasTreeDecoratorBase(TreeBase tree)
        {
            _treeBase = tree;
        }

        public override string AddMessage()
        {
            return _treeBase.AddMessage();
        }
    }
}
