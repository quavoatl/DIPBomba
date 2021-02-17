using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class CarWashService : AbstractService
    {
        public CarWashService(string name, double price) : base(name, price) { }
    }
}
