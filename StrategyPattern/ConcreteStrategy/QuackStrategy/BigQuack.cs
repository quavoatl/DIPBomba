using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interfaces;

namespace StrategyPattern.ConcreteStrategy.QuackStrategy
{
   public class BigQuack : IQuackDuck
    {
        public void Quack()
        {
            Console.WriteLine("Coaie so QUACKU ce bag");
        }
    }
}
