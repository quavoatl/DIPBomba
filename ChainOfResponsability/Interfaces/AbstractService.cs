using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability.Interfaces
{
    public abstract class AbstractService
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public AbstractService(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
