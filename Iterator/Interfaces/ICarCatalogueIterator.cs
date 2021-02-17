using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Interfaces
{
    public interface ICarCatalogueIterator
    {
        AbstractCar next();
        bool hasNext();
    }
}
