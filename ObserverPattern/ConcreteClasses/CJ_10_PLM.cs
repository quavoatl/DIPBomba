using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using ObserverPattern.Interfaces;

namespace ObserverPattern.ConcreteClasses
{
    public class CJ_10_PLM : ICarObserver
    {
        private ISubject _carSubject;
        private IPayParking _prefferedParkingPayment;
        private int _capacity;
        private double _ticketPrice;
      
        public void Update(AbsDataForCarObserver parkCarDetails)
        {
            this._capacity = parkCarDetails.Capacity;
            this._ticketPrice = parkCarDetails.TicketPrice;
        }

        public CJ_10_PLM(ISubject carSubject, IPayParking payParking)
        {
            _carSubject = carSubject;
            _prefferedParkingPayment = payParking;
            _carSubject.AddCarUser(this);
        }

        public void BuyTicket()
        {
            if (_capacity > 0)
            {
                _prefferedParkingPayment.ProcessPayment();
            }
            else
            {
                Console.WriteLine($"No spots in the parking lot atm");
            }
        }
    }
}
