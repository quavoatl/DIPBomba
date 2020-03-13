using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes
{
    class PersoanaCuPermisacio : IPerson
    {
        private Vehicle vehicle;
        private Carnet _carnet;
        private string name;
        private int age;

        public Vehicle Vehicle
        {
            get => vehicle;
            set => vehicle = value;
        }

        public Carnet Carnet
        {
            get => _carnet;
            set => _carnet = value;
        }

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
            this.vehicle = vehicle;
            _carnet = carnet;
            this.name = name;
            this.age = age;
        }

        public PersoanaCuPermisacio(Carnet carnet)
        {
            this._carnet = carnet;
        }

        public void CumparaVehicul(Enums.VehiculDetinut vehicul)
        {
            this.vehicle = Factory.CreateAVehicle(vehicul);
        }

    }
}
