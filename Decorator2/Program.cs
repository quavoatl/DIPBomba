using System;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeBase tree = new ChristmasTreeConcreteDecorator2(new ChristmasTreeConcreteDecorator1(new ChristmasTree("brad de craciun misto")));
            Console.WriteLine(tree.AddMessage());
        }
    }
}
