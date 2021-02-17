using System;
using System.Collections.Generic;
using System.Text;
using State.Interfaces;

namespace State.ConcreteStates
{
    public class ReleaseSodaState : IState
    {
        private ISodaMachine _sodaMachine;

        public ReleaseSodaState(ISodaMachine sodaMachine)
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
            if(_sodaMachine.FoundSoda != null && _sodaMachine.CurrentBalance >= _sodaMachine.FoundSoda.Price)
            {
                Console.WriteLine($"Here comes your {_sodaMachine.FoundSoda.Name}");
                _sodaMachine.CurrentBalance = _sodaMachine.FoundSoda.Price;
                _sodaMachine.ListOfSodas.Remove(_sodaMachine.FoundSoda);
            }
            else
            {
                Console.WriteLine("No such item in our vending machine/Insufficient balance");
            }
            _sodaMachine.CurrentState = _sodaMachine.ReadyForOperationState;
        }

        public bool SelectSoda(AbstractSoda soda)
        {
            Console.WriteLine("Invalid Operation");
            return false;
        }
    }
}
