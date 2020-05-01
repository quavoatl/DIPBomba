using System;
using System.Collections.Generic;
using System.Text;
using Composite.Interfaces;

namespace Composite.ConcreteClasses
{
    public class MenuItem : AbstractMenuComponent
    {
        private string _name;
        private string _description;
        private bool _isVegetarian;
        private double _price;

        public MenuItem(string name, string desc, bool isVegetarian, double price)
        {
            this._name = name;
            this._description = desc;
            this._isVegetarian = isVegetarian;
            this._price = price;
        }

        public override string getDescription()
        {
            return _description;
        }

        public override double getPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _isVegetarian;
        }

        public override void Print()
        {
            Console.WriteLine($"{_name} \n" +
                $"  -{_description}, vegetarian: {IsVegetarian()}, {_price}");
        }

    }
}
