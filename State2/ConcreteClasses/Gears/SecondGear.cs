using System;
using System.Collections.Generic;
using System.Text;
using State2.Interfaces;

namespace State2.ConcreteClasses.Gears
{
    public class SecondGear : AbstractGear
    {
        public SecondGear(int gear) : base(gear) { }
    }
}
