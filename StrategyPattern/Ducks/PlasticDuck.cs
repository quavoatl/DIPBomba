using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.ConcreteStrategy.QuackStrategy;
using StrategyPattern.FlyingStrategy;

namespace StrategyPattern.Ducks
{
    public class PlasticDuck : Duck
    {
        public PlasticDuck()
        {
            FlyingDuck = new NoFly();
            QuackDuck = new NoQuack();
        }
    }
}
