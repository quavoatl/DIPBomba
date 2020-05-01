using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Interfaces
{
    public interface ICarsCatalogue
    {
        void addCar(AbstractCar car);
        ICarCatalogueIterator createIterator();
    }
}
