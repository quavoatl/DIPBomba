using System;
using System.Collections.Generic;
using System.Text;

namespace FoodSystemComponent
{
    public class FoodSystem
    {
        private IFoodSystemState _state;

        public FoodSystem()
        {
            //_state = set initial state
            _state = new GuestUserState();
        }

        public void SetNextState(IFoodSystemState state)
        {
            _state = state;
        }

        public void Login(string user, string pass)
        {
            _state.Login(this, user, pass);
        }

        public void Logout()
        {
            _state.Logout(this);
        }

        public void ShowFood()
        {
            _state.ShowFood(this);
        }

        public void OrderFood(int id)
        {
            _state.OrderFood(this, id);
        }

        public void ListOrderedFood()
        {
            _state.ListOrderedFood(this);
        }


    }
}
