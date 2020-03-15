using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Interfaces;

namespace ObserverPattern.ConcreteClasses
{
    public class CrediCardPayCarParking : IPayParking
    {
        private IParkCarDetails _parkCarDetails;
        public IParkCarDetails ParkCarDetails
        {
            get => _parkCarDetails;
            set => _parkCarDetails = value;
        }

        public CrediCardPayCarParking(IParkCarDetails parkCarDetails)
        {
            _parkCarDetails = parkCarDetails;
        }

        public void UpdatePark(IParkCarDetails carDetails)
        {
            _parkCarDetails.Capacity -= 1;
            Console.WriteLine($"You bought a ticket via CC, paid : {_parkCarDetails.TicketPrice}");
        }
    }
}
