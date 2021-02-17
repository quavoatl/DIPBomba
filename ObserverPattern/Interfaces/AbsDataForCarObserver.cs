using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class AbsDataForCarObserver
    {
        public virtual int Capacity { get; set; }
        public virtual double TicketPrice { get; set; }
    }
}
