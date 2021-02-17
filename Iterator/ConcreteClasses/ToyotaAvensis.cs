using System.Collections.Generic;
using System.Text;
using Iterator.Interfaces;

namespace Iterator.ConcreteClasses
{
    public class ToyotaAvensis : AbstractCar
    {
        public ToyotaAvensis(string manufacturer, string model, double price) : base(manufacturer, model, price) { }
    }
}
