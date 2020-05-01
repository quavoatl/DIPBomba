using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Interfaces
{
   public abstract class AbstractMenuComponent
    {
        public virtual void add(AbstractMenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual Object GetMenuComponent(int i)
        {
            return new NotSupportedException();
        }

        public virtual double getPrice()
        {
            throw new NotSupportedException();
        }

        public virtual string getDescription()
        {
            throw new NotSupportedException();
        }

        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
