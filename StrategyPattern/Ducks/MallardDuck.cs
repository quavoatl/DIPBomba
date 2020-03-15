using StrategyPattern.FlyingStrategy;
using StrategyPattern.ConcreteStrategy.QuackStrategy;

namespace StrategyPattern.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyingDuck = new FlyWithWings();
            QuackDuck = new BigQuack();
        }
    }
}
