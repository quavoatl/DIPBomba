using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes
{
    class PersoanaCuPermisacio : IDrivePerson
    {
        private Vehicle _vehiculCurent;
        private Carnet _carnetel;
        private string name;
        private int age;

       
        public Carnet _Carnet { get => _carnetel; set => _carnetel = value; }
        public Vehicle VehiculCurent { get => _vehiculCurent; set => _vehiculCurent = value; }
        public SortedSet<Vehicle> VehiculeDetinute { get; set; }



        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public PersoanaCuPermisacio(Vehicle vehicle, Carnet carnet, string name, int age)
        {
            this._vehiculCurent = vehicle;
            _Carnet = carnet;
            this.name = name;
            this.age = age;
        }

        public PersoanaCuPermisacio(Carnet carnet)
        {
            this._Carnet = carnet;
        }

        public void CumparaVehicul(Vehicle vehicle)
        {
            if(VehiculeDetinute == null)
            {
                this.VehiculeDetinute = new SortedSet<Vehicle>();
            }
            this.VehiculeDetinute.Add(vehicle);
        }

        public void Drive(Vehicle vehicle)
        {
            if (VehiculeDetinute.Contains(vehicle))
            {
                _vehiculCurent = vehicle;
            }
        }
    }
}
