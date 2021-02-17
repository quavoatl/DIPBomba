using System;
using System.Collections.Generic;
using System.Text;
using FoodDataAccess;
using FoodModel;

namespace FoodSystemComponent
{
    public class FoodOrderedState : IFoodSystemState
    {
        private IFoodDataAccess _foodDataAccess;
        private List<Food> _orderedFood = new List<Food>();

        public FoodOrderedState(Food food)
        {
            _foodDataAccess = new FoodDataAccessDB();
            _orderedFood.Add(food);
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
            _orderedFood.Add(food);
        }

        public void ListOrderedFood(FoodSystem context)
        {
            foreach (var food in _orderedFood)
            {
               Console.WriteLine($"Food you ordered: {food.Name}");
            }
        }
    }
}
