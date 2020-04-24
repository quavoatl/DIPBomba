using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Interfaces;

namespace Iterator.ConcreteClasses
{
    public class ToyotaCarCatalogueIterator : ICarCatalogueIterator
    {
        private IList<AbstractCar> _toyotaCatalogueList;
        private int _arrayPosition = 0;

        public ToyotaCarCatalogueIterator(IList<AbstractCar> toyotaCatalogue)
        {
            _toyotaCatalogueList = toyotaCatalogue;
        }

        public bool hasNext()
        {
            if (_arrayPosition < _toyotaCatalogueList.Count) return true;
            else return false;
        }

        public AbstractCar next()
        {
            try
            {
                AbstractCar abstractCar = _toyotaCatalogueList[_arrayPosition];
                return abstractCar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occured...");
            }
            finally
            {
                _arrayPosition++;
            }

            return null;
        }
    }
}
