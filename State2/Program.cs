using System;
using State2.Interfaces;
using State2.ConcreteClasses;
namespace State2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar toyota = new ToyotaCar("Avensis");
            toyota.PowerUp();
            toyota.SwitchGearUp();
            toyota.SwitchGearUp();
            toyota.SwitchGearUp();
            toyota.SwitchGearUp();
            toyota.SwitchGearDown();
            toyota.SwitchGearDown();
            toyota.PowerOff();
            toyota.PowerUp();
            toyota.SwitchGearUp();
        }
    }
}
