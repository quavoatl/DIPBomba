using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface ISubject
    {
        void AddCarUser(ICarObserver carObserver);
        void RemoveUser(ICarObserver carObserver);
        void NotifyUsers();
        List<ICarObserver> Observers { get; set; }
    }
}
