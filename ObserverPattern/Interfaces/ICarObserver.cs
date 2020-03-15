using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
   public interface ICarObserver
   {
       void Update(IParkCarDetails parkCarDetails);
   }
}
