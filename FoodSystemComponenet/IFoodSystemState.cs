using System;

namespace FoodSystemComponent
{
    public interface IFoodSystemState
    {
        void Login(FoodSystem context, string user, string pass);
        void Logout(FoodSystem context);
        void ShowFood(FoodSystem context);
        void OrderFood(FoodSystem context, int id);
        void ListOrderedFood(FoodSystem context);
    }
}
