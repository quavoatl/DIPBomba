using System;
using FoodSystemComponent;

namespace FoodClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodSystem foodSystem = new FoodSystem();
            foodSystem.OrderFood(2);

            //foodSystem.Login("asd","dsa");
            //foodSystem.OrderFood(2);
        }
    }
}
