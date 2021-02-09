using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class CarTyreService : AbstractService
    {
        public CarTyreService(string name, double price) : base(name, price) { }
    }
}
