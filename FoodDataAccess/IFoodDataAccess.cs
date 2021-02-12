using System;
using System.Collections.Generic;
using FoodModel;

namespace FoodDataAccess
{
    public interface IFoodDataAccess
    {
        Food GetFood(int id);
        List<Food> GetAllFoods();
    }
}
