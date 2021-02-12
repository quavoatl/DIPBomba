using System;
using System.Collections.Generic;
using System.Text;
using FoodDataAccess;

namespace FoodSystemComponent
{
    public class LoggedInState : IFoodSystemState
    {
        private IFoodDataAccess _foodDataAccess;

        public LoggedInState()
        {
            _foodDataAccess = new FoodDataAccessDB();
        }

        public void Login(FoodSystem context, string user, string pass)
        {
            Console.WriteLine("You are already logged in");
        }

        public void Logout(FoodSystem context)
        {
            Console.WriteLine("You logged out!");
            context.SetNextState(new GuestUserState());
        }

        public void ShowFood(FoodSystem context)
        {
            Console.WriteLine("Currently we have in stock : ");
            foreach (var food in _foodDataAccess.GetAllFoods())
            {
                Console.WriteLine($"{food.Name} / for: {food.Price}");
            }
        }

        public void OrderFood(FoodSystem context, int id)
        {
            var food = _foodDataAccess.GetFood(id);
           Console.WriteLine($"You ordered: {food.Name}");
           context.SetNextState(new FoodOrderedState(food));

        }

        public void ListOrderedFood(FoodSystem context)
        {
            Console.WriteLine("No food ordered yet !!!");
        }
    }
}
