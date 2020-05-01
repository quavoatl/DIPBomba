using System;
using System.Collections.Generic;
using System.Text;
using State.Interfaces;

namespace State.ConcreteStates
{
    public class ReadyForOperationState : IState
    {
        private ISodaMachine _sodaMachine;
        public ReadyForOperationState(ISodaMachine sodaMachine)
        {
            this._sodaMachine = sodaMachine;
        }

        public void AddMoney(double money)
        {
            _sodaMachine.AddMoney(money);
        }

        public void ReadyForOperation()
        {
            Console.WriteLine($"This machine is ready for an operation. Current balance: {_sodaMachine.CurrentBalance}");
        }

        public void ReleaseSoda()
        {
            Console.WriteLine("First you have to select a soda.");
        }

        public bool SelectSoda(AbstractSoda soda)
        {
            _sodaMachine.CurrentState = _sodaMachine.SelectSodaState;
            return _sodaMachine.CurrentState.SelectSoda(soda);
        }
    }
}
