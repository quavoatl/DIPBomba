using System;
using System.Collections.Generic;
using System.Text;
using State.Interfaces;
using State.ConcreteStates;

namespace State.ConcreteClasses
{
    public class SodaMachine : ISodaMachine
    {
        private IState _readyForOperationState;
        private IState _addMoneyState;
        private IState _selectSodaState;
        private IState _releaseSodaState;

        private IState _currentState;
        private double _currentBalance = 0;
        private List<AbstractSoda> _listOfSodas;
        private AbstractSoda _foundSoda;

        public double CurrentBalance { get => _currentBalance; set => _currentBalance = value; }
        public List<AbstractSoda> ListOfSodas { get => _listOfSodas; set => _listOfSodas = value; }
        public IState CurrentState { get => _currentState; set => _currentState = value; }
        public AbstractSoda FoundSoda { get => _foundSoda; set => _foundSoda = value; }

        public IState ReadyForOperationState { get => _readyForOperationState; set => _readyForOperationState = value; }
        public IState SelectSodaState { get => _selectSodaState; set => _selectSodaState = value; }
        public IState ReleaseSodaState { get => _releaseSodaState; set => _releaseSodaState = value; }

        public SodaMachine()
        {
            _readyForOperationState = new ReadyForOperationState(this);
            _addMoneyState = new AddMoneyState(this);
            _selectSodaState = new SelectSodaState(this);
            _releaseSodaState = new ReleaseSodaState(this);
            this._listOfSodas = new List<AbstractSoda>();
            _currentState = _addMoneyState;
        }

        public void AddMoney(double money)
        {
            _currentState.AddMoney(money);
        }

        public bool SelectSoda(AbstractSoda soda)
        {
            return _currentState.SelectSoda(soda);
        }

        public void ReleaseSoda()
        {
            Console.WriteLine("First you have to select a soda");
        }
    }
}
