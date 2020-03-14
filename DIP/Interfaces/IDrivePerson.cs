using DIP.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interfaces
{
    public interface IDrivePerson : IPerson
    {
        Vehicle VehiculCurent { get; set; }
        SortedSet<Vehicle> VehiculeDetinute { get; set; }
        Carnet _Carnet { get; set; }
        void Drive(Vehicle vehicle);
    }
}
