using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class AbstractPizzaStore
    {
        public abstract AbstractPizza CreatePizza(string type);
        public void orderPizza(string type)
        {
            AbstractPizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Ship();
        }
    }
}
