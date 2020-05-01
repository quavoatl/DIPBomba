using System;
using System.Collections.Generic;
using System.Text;
using Composite.Interfaces;

namespace Composite.ConcreteClasses
{
    public class PriceLowerThan5 : ISpecification
    {
        public bool IsSatisfied(AbstractMenuComponent item)
        {
            if (item.getPrice() < 5.00)
            {
                Console.WriteLine($"{ item.getDescription()} costs: {item.getPrice()}");
                return true;
            }
            else return false;
        }
    }
}
