using DIP.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interfaces {
    public interface IPerson {
        public string Name { get; set; }
        public int Age { get; set; }
        public License License { get; set; }
        public List<Vehicle> ? Vehicles { get; set; }
        public Vehicle ? Vehicle { get; set; }
        void Drive(Vehicle vehicle);
        void BuyVehicle(Vehicle vehicle);
    }

    public enum PersonType 
    {
        Simple,
        CarDriver,
        Policeman,
        LicenseCreator
    }
}
