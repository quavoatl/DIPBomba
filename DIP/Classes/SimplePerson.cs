using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes
{
    public class SimplePerson : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void CumparaVehicul(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}