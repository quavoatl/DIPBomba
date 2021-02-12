using System;
using System.Collections.Generic;
using System.Text;
using FoodModel;

namespace FoodDataAccess
{
    public class FoodDataAccessDB : IFoodDataAccess
    {
        private List<Food> _foodInDb;

        public FoodDataAccessDB()
        {
            _foodInDb = new List<Food>(new Food[]
            {
                new Food(1,"Ciorba",0.6),
                new Food(2,"Cartofi",1),
                new Food(3,"Carne",2)
            });
        }

        public Food GetFood(int id)
        {
            return _foodInDb.Find(f => f.Id.Equals(id));
        }

        public List<Food> GetAllFoods()
        {
            return _foodInDb;
        }
    }
}
