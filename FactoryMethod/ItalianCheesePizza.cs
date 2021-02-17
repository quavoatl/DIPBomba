using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ItalianCheesePizza : AbstractPizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public double Price { get; set; }
        public ItalianCheesePizza()
        {
            Name = "Traditional Italian Cheese Pizza";
            Dough = "Nice thin crust";
            Sauce = "Sweet tomato sauce";
            Price = 23.50;
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the pizza for 25 minutes at 250C");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza in nice diagonal shapes");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing the {Dough}\n" +
                $"Adding the {Sauce}");
        }

        public override void Ship()
        {
            base.Ship();
            Console.WriteLine($"   Total price: {Price}");
        }
    }
}
