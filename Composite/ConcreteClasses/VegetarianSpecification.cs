using System;
using System.Collections.Generic;
using System.Text;
using Composite.Interfaces;

namespace Composite.ConcreteClasses
{
    public class VegetarianSpecification : ISpecification
    {
        public bool IsSatisfied(AbstractMenuComponent item)
        {
            if (item.IsVegetarian())
            {
                Console.WriteLine($"Item: {item.getDescription()} is vegeratian");
                return true;
            }
            else return false;
        }
    }
}
