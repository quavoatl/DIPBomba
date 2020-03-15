using System;
using StrategyPattern.Ducks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            Duck plasticDuck = new PlasticDuck();
            plasticDuck.PerformFly();
            plasticDuck.PerformQuack();
        }
    }
}
