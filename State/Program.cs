using System;
using State.ConcreteClasses;
using State.Interfaces;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractSoda cola = new CocaColaSoda("Coca Cola Zero", 500, 2.50);
            AbstractSoda fanta = new FantaSoda("Fanta Madness", 500, 2.60);
            AbstractSoda sprite = new SpriteSoda("Sprite - Regular Flavor", 500, 3.10);
            ISodaMachine sodaMachine = new SodaMachine();
            sodaMachine.ListOfSodas.Add(cola);
            sodaMachine.ListOfSodas.Add(fanta);
            sodaMachine.ListOfSodas.Add(sprite);

            sodaMachine.AddMoney(5);
            sodaMachine.SelectSoda(cola);
            sodaMachine.SelectSoda(fanta);

        }
    }
}
