using System;
using System.Collections.Generic;
using System.Text;
using State.Interfaces;

namespace State.ConcreteClasses
{
   public class CocaColaSoda : AbstractSoda
    {
        public CocaColaSoda(string name, int weight, double price) : base(name, weight, price) { }
    }
}
