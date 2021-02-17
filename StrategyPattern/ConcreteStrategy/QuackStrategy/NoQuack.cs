using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interfaces;

namespace StrategyPattern.ConcreteStrategy.QuackStrategy
{
   public class NoQuack : IQuackDuck
    {
        public void Quack()
        {
            Console.WriteLine("Vai de mortii mei nu pot face QUACK");
        }
    }
}
