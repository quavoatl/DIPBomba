using System;
using System.Collections.Generic;
using System.Text;
using State.Interfaces;

namespace State.Interfaces
{
    public interface ISodaMachine
    {
        public double CurrentBalance { get; set; }
        public List<AbstractSoda> ListOfSodas { get; set; }
        public IState CurrentState { get; set; }
        public AbstractSoda FoundSoda { get; set; }
        public IState ReadyForOperationState { get; set; }
        public IState SelectSodaState { get; set; }
        public IState ReleaseSodaState { get; set; }
        void AddMoney(double money);
        bool SelectSoda(AbstractSoda soda);
        void ReleaseSoda();
    }
}
