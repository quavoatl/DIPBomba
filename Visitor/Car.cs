using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class Car : IVisitable
    {
        public virtual double Price { get; set; } = 2000;

        public void Accept(ICarVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
  
}
