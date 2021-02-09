using System;
using System.Collections.Generic;
using System.Text;

namespace State.Interfaces
{
    public abstract class AbstractSoda
    {
        private string _name;
        private int _weight;
        private double _price;

        public string Name { get=> _name; set=> _name = value; }
        public int Weight { get=> _weight; set=> _weight = value; }
        public double Price { get=> _price; set=> _price = value; }

        public AbstractSoda(string name, int weight, double price)
        {
            this._name = name;
            this._weight = weight;
            this._price = price;
        }

    }
}
