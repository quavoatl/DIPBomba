using System;
using System.Collections.Generic;
using System.Text;
using State.Interfaces;

namespace State.ConcreteStates
{
    public class AddMoneyState : IState
    {
        private ISodaMachine _sodaMachine;
        public AddMoneyState(ISodaMachine sodaMachine)
        {
            this._sodaMachine = sodaMachine;
        }

        public void AddMoney(double money)
        {
            _sodaMachine.CurrentBalance += money;
            _sodaMachine.CurrentState = _sodaMachine.ReadyForOperationState;
            _sodaMachine.CurrentState.ReadyForOperation();
        }

        public void ReadyForOperation()
        {
            Console.WriteLine("Ready for an operation.");
        }

        public void ReleaseSoda()
        {
            Console.WriteLine("First you have to select a soda.");
        }

        public bool SelectSoda(AbstractSoda soda)
        {
            if(_sodaMachine.CurrentBalance > 0)
            {
                _sodaMachine.CurrentState = _sodaMachine.SelectSodaState;
                _sodaMachine.CurrentState.SelectSoda(soda);
            }
            Console.WriteLine("First you have to add some money");
            return false;
        }
    }
}
