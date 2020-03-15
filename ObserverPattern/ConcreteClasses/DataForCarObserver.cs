using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConcreteClasses
{
    class DataForCarObserver : AbsDataForCarObserver
    {
        private int _capacity;
        private double _ticketPrice;

        public override int Capacity { get => _capacity; set => _capacity = value; }
        public virtual double TicketPrice { get=> _ticketPrice; set=> _ticketPrice = value; }

        public DataForCarObserver(int cap, double price)
        {
            this._capacity = cap;
            this._ticketPrice = price;
        }
    }
}
