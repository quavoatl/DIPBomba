using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interfaces;
using StrategyPattern.Interfaces.StrategyInterfaces;

namespace StrategyPattern.FlyingStrategy
{
    public class FlyWithWings : IFlyingDuck
    {
        public void Fly()
        {
            Console.WriteLine("No stress dau din aripi si zbor");
        }
    }
}
