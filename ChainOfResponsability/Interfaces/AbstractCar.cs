using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability.Interfaces
{
    public abstract class AbstractCar
    {
        public string Name { get; private set; }
        public List<AbstractService> ServicesRequired { get; private set; }

        public AbstractCar(string name, List<AbstractService> servicesRequired)
        {
            Name = name;
            ServicesRequired = servicesRequired;
        }

        public bool IsServiceComplete()
        {
            if (ServicesRequired.Count.Equals(0))
            {
                return true;
            }
            else return false;
        }
    }
}
