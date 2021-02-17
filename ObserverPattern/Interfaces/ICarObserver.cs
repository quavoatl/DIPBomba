using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
   public interface ICarObserver
   {
       void BuyTicket();
       void Update(AbsDataForCarObserver data);
   }
}
