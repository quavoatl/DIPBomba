using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Interfaces;

namespace Iterator.ConcreteClasses
{
    public class VolkswagenCarCatalogueIterator : ICarCatalogueIterator
    {
        private AbstractCar[] _volkswagenCatalogue;
        private int _arrayPosition = 0;

        public VolkswagenCarCatalogueIterator(AbstractCar[] volkswagenCatalogue) 
        {
            this._volkswagenCatalogue = volkswagenCatalogue;
        }

        public bool hasNext()
        {
            if (_arrayPosition < _volkswagenCatalogue.Length) return true;
            else return false;
        }

        public AbstractCar next()
        {
            AbstractCar abstractCar = _volkswagenCatalogue[_arrayPosition];
            _arrayPosition++;
            return abstractCar;
        }
    }
}
