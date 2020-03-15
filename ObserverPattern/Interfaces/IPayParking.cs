using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface IPayParking
    {
        IParkCarDetails ParkCarDetails { get; set; }
        void UpdatePark(IParkCarDetails carDetails);
    }
}
