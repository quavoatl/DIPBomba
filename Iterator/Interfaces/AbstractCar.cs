using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Interfaces
{
    public abstract class AbstractCar
    {
        private string _manufacturer;
        private string _model;
        private double _price;

        public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public string Model { get => _model; set => _model = value; }
        public double Price { get => _price; set => _price = value; }

        public AbstractCar(string manufacturer, string model, double price)
        {
            this._manufacturer = manufacturer;
            this._model = model;
            this._price = price;
        }
    }
}
