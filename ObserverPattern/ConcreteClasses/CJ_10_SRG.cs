using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using ObserverPattern.Interfaces;

namespace ObserverPattern.ConcreteClasses
{
    public class CJ_10_SRG : ICarObserver,IBuyTicket
    {
        private ISubject _carSubject;
        private IPayParking _prefferedParkingPayment;
        private int _capacity;
        private double _ticketPrice;
        private bool wantsTicket = false;

        public bool WantsTicket
        {
            get => wantsTicket;
            set => wantsTicket = value;
        }

        public void Update(IParkCarDetails parkCarDetails)
        {
            this._capacity = parkCarDetails.Capacity;
            this._ticketPrice = parkCarDetails.TicketPrice;
            if (wantsTicket && _capacity > 0)
            {
                BuyTicket(_prefferedParkingPayment);
                wantsTicket = false;
            }
        }

        public CJ_10_SRG(ISubject carSubject, IPayParking payParking)
        {
            _carSubject = carSubject;
            _prefferedParkingPayment = payParking;
            _carSubject.AddCarUser(this);
        }

        public void BuyTicket(IPayParking payParking)
        {
            payParking.UpdatePark(payParking.ParkCarDetails);
        }
    }
}
