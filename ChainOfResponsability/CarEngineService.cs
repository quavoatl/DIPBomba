using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class CarEngineService : AbstractService
    {
        public CarEngineService(string name, double price) : base(name, price) { }
    }
}
