using System.Collections.Generic;
using System.Text;
using Iterator.Interfaces;

namespace Iterator.ConcreteClasses
{
    public class ToyotaYaris : AbstractCar
    {
        public ToyotaYaris(string manufacturer, string model, double price) : base(manufacturer, model, price) { }
    }
}
