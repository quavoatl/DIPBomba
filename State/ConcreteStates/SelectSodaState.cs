using System;
using System.Collections.Generic;
using System.Text;
using State.Interfaces;

namespace State.ConcreteStates
{
    public class SelectSodaState : IState
    {
        private ISodaMachine _sodaMachine;

        public SelectSodaState(ISodaMachine sodaMachine)
        {
            this._sodaMachine = sodaMachine;
        }

        public void AddMoney(double money)
        {
            Console.WriteLine("You are in an operation and you can't add money now.");
        }

        public void ReadyForOperation()
        {
            Console.WriteLine("Machine in operation...");
        }

        public void ReleaseSoda()
        {
            Console.WriteLine("First you have to select a soda.");
        }

        public bool SelectSoda(AbstractSoda soda)
        {
            if (_sodaMachine.ListOfSodas.Contains(soda))
            {
                _sodaMachine.FoundSoda = soda;
                _sodaMachine.CurrentState = _sodaMachine.ReleaseSodaState;
                _sodaMachine.CurrentState.ReleaseSoda();
                return true;
            }
            else
            {
                Console.WriteLine("No such item in our vending machine");
                return false;
            }
        }
    }
}
