using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Interfaces;

namespace Iterator.ConcreteClasses
{
    public class VolkswagenPassat : AbstractCar
    {
        public VolkswagenPassat(string manufacturer, string model, double price) : base(manufacturer, model, price) { }
    }
}
