using System;
using System.Collections.Generic;
using System.Text;
using State2.Interfaces;

namespace State2.ConcreteClasses.Gears
{
    public class FirstGear : AbstractGear
    {
        public FirstGear(int gear) : base(gear) { }
    }
}
