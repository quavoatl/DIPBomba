using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
   public abstract class AbstractPizza
    {
        public string Name { get; set; }
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public virtual void Ship()
        {
            Console.WriteLine($"Shipping you the {Name}...");
        }

    }
}
