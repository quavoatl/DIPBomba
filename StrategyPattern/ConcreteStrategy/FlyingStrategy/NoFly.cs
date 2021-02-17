using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interfaces;
using StrategyPattern.Interfaces.StrategyInterfaces;

namespace StrategyPattern.FlyingStrategy
{
    public class NoFly : IFlyingDuck
    {
        public void Fly()
        {
            Console.WriteLine("Sa moara mama ca n am cum sa zbor");
        }
    }
}
