using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Interfaces;

namespace ObserverPattern.ConcreteClasses
{
    public class CentralParkingSubject : ISubject
    {
        private IParkCarDetails _parkCarDetails;
        private List<ICarObserver> _observers;
        private int _capacity = 0;
        private double _ticketPrice = 0;

        public int Capacity
        {
            get => _capacity;
            set => _capacity = value;
        }

        public double TicketPrice
        {
            get => _ticketPrice;
            set => _ticketPrice = value;
        }

        public CentralParkingSubject(IParkCarDetails parkCarDetails)
        {
            _observers = new List<ICarObserver>();
            this._parkCarDetails = parkCarDetails;
        }

        public void AddCarUser(ICarObserver carObserver)
        {
            this._observers.Add(carObserver);
        }

        public void RemoveUser(ICarObserver carObserver)
        {
            _observers.Remove(carObserver);
        }

        public List<ICarObserver> Observers
        {
            get => _observers;
            set => _observers = value;
        }

        private void GetParkDetails()
        {
            _capacity = _parkCarDetails.Capacity;
            _ticketPrice = _parkCarDetails.TicketPrice;
            Console.WriteLine($"At this moment we have {_capacity} parking slots\n" +
                              $"    - Price for one ticket {_ticketPrice}");
        }

        public void NotifyUsers()
        {
            GetParkDetails();
            foreach (var carObserver in _observers)
            {
                carObserver.Update(_parkCarDetails);
            }
        }
                

    }
}
