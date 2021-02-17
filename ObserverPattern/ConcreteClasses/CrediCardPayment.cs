using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Interfaces;

namespace ObserverPattern.ConcreteClasses
{
    public class CrediCardPayment : IPayParking
    {
        private IParkCarDetails _parkCarDetails;
        public IParkCarDetails ParkCarDetails
        {
            get => _parkCarDetails;
            set => _parkCarDetails = value;
        }

        public CrediCardPayment(IParkCarDetails parkCarDetails)
        {
            _parkCarDetails = parkCarDetails;
        }

        public void ProcessPayment()
        {
            _parkCarDetails.Capacity -= 1;
            Console.WriteLine($"You bought a ticket via CC, paid : {_parkCarDetails.TicketPrice}");
        }
    }
}
