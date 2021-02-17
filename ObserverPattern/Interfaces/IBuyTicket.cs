using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface IBuyTicket
    {
        void BuyTicket(IPayParking paymentProcessor);
    }
}
