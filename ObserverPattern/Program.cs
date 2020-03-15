using System;
using ObserverPattern.ConcreteClasses;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IParkCarDetails centralParkCarDetails = new CentralParkingDetails();
            ISubject centralParkSubject = new CentralParkingSubject(centralParkCarDetails);
            IPayParking ccPayment = new CrediCardPayCarParking(centralParkCarDetails);
            CJ_10_SRG CJ_10_SRG = new CJ_10_SRG(centralParkSubject, ccPayment);

            centralParkCarDetails.TicketPrice = 5.50;
            centralParkCarDetails.Capacity = 70;

            centralParkSubject.NotifyUsers();
            CJ_10_SRG.WantsTicket = true;
            centralParkSubject.NotifyUsers();
            Console.WriteLine($"{centralParkCarDetails.Capacity}");
            centralParkSubject.NotifyUsers();
        }
    }
}