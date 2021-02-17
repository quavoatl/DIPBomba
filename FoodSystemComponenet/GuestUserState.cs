using System;
using System.Collections.Generic;
using System.Text;

namespace FoodSystemComponent
{
    public class GuestUserState : IFoodSystemState
    {
        public void Login(FoodSystem context, string user, string pass)
        {
            Console.WriteLine($"Logged in as {user}");
            context.SetNextState(new LoggedInState());
        }

        public void Logout(FoodSystem context)
        {
           Console.WriteLine("You are not logged in yet !");
        }

        public void ShowFood(FoodSystem context)
        {
            Console.WriteLine("You are not logged in yet !");
        }

        public void OrderFood(FoodSystem context,int id)
        {
            Console.WriteLine("You are not logged in yet !");
        }

        public void ListOrderedFood(FoodSystem context)
        {
            Console.WriteLine("You are not logged in yet !");
        }
    }
}
