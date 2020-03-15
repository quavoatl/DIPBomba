using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface IParkCarDetails
    {
        int Capacity { get; set; }
        double TicketPrice { get; set; }
    }
}
