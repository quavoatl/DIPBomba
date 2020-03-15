using System;
using ObserverPattern.ConcreteClasses;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IParkCarDetails centralParkCarDetails = new CentralParkingDetails(10,6.70);
            ISubject centralParkSubject = new CentralParkingSubject(centralParkCarDetails);
            ICarObserver CJ_10_PLM = new CJ_10_PLM(centralParkSubject, 
                                        new CrediCardPayment(centralParkCarDetails));

            centralParkSubject.NotifyUsers();
            CJ_10_PLM.BuyTicket();
            centralParkSubject.NotifyUsers();
        }
    }
}