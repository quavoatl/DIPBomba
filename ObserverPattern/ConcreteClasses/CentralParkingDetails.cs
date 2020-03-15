using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Interfaces;

namespace ObserverPattern.ConcreteClasses
{
    public class CentralParkingDetails : IParkCarDetails
    {
        private int _capacity;
        private double _ticketPrice;
        public int Capacity { get => _capacity; set => _capacity = value; }
        public double TicketPrice { get => _ticketPrice; set=> _ticketPrice = value; }

        public CentralParkingDetails(int cap, double price)
        {
            this._capacity = cap;
            this._ticketPrice = price;
        }
    }
}
