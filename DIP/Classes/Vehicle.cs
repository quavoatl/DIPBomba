using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Classes
{
    public class Vehicle
    {
        private VehicleTypes _vehicleType;
        private LicenseCategory _neccessaryCategory;
        private string _vehicleInUse;

        public VehicleTypes VehicleType
        {
            set => _vehicleType = value;
        }

        public string VehicleInUse
        {
            get => GetVehicleType();
        }

        public LicenseCategory _NeccessaryCategory
        {
            get => _neccessaryCategory;
            set => _neccessaryCategory = value;
        }


        public string GetVehicleType()
        {
            return Enum.GetName(typeof(VehicleTypes), _vehicleType);
        }

        public Vehicle(VehicleTypes vehicleType)
        {
            this._vehicleType = vehicleType;
        }
    }

    public enum VehicleTypes // repetition
    {
        Toyota,
        Audi,
        TIRVolvo,
        TIRScania,
        SotoCaruta
    }
}
