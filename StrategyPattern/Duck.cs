using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Interfaces;
using StrategyPattern.Interfaces.StrategyInterfaces;

namespace StrategyPattern
{
    public abstract class Duck
    {
        private IFlyingDuck _flyingDuck;
        private IQuackDuck _quackDuck;

        public IFlyingDuck FlyingDuck
        {
            get => _flyingDuck;
            set => _flyingDuck = value;
        }

        public IQuackDuck QuackDuck
        {
            get => _quackDuck;
            set => _quackDuck = value;
        }

        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming like every ducks do");
        }

        public void PerformFly()
        {
            _flyingDuck.Fly();
        }

        public void PerformQuack()
        {
            _quackDuck.Quack();
        }
    }
}
