using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPizzaStore romanianStore = new RomanianPizzaStore();
            romanianStore.orderPizza("Cheese");
            Console.WriteLine("***********************************");
            AbstractPizzaStore italianStore = new ItalianPizzaStore();
            italianStore.orderPizza("Cheese");
        }
    }
}
