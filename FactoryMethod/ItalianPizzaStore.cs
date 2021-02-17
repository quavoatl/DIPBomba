using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ItalianPizzaStore : AbstractPizzaStore
    {
        public override AbstractPizza CreatePizza(string type)
        {
            AbstractPizza pizza = null;
            if (type.Equals("Cheese"))
            {
                pizza = new ItalianCheesePizza();
            }
            return pizza;
        }
    }
}
