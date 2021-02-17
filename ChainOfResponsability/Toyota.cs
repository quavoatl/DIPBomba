using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Toyota : AbstractCar
    {
        public Toyota(string name, List<AbstractService> servicesRequired) : base(name, servicesRequired) { }
    }
}
