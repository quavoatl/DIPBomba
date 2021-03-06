using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes {
    class CarDriverPerson : IPerson {
        public string Name { get; set; }
        public int Age { get; set; }
        public License? License { get; set; }
        public List<Vehicle>? Vehicles { get; set; }
        public Vehicle? Vehicle { get; set; }

        public void Drive(Vehicle vehicle)
        {
            if (Vehicles.Contains(vehicle))
            {
                this.Vehicle = vehicle;
                Console.WriteLine($"{Name} conduce: {vehicle.VehicleInUse}");
            }
        }

        public void BuyVehicle(Vehicle vehicle)
        {
            if (Vehicles == null)
            {
                Vehicles = new List<Vehicle>();
            }
             this.Vehicles.Add(vehicle);
        }
    }
}
