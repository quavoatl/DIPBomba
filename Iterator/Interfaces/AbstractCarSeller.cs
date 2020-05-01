using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Interfaces
{
    public abstract class AbstractCarSeller
    {
        private string _name;
        private string _company;
        private IList<ICarCatalogueIterator> _carCatalogueIterators;

        public AbstractCarSeller(string name,string company, IList<ICarCatalogueIterator> carCatalogueIterators)
        {
            this._name = name;
            this._company = company;
            this._carCatalogueIterators = carCatalogueIterators;
        }

        public void GetCarsInformation()
        {
            foreach(var carIterator in _carCatalogueIterators)
            {
                while (carIterator.hasNext()) 
                {
                    AbstractCar absCar = carIterator.next();
                    Console.WriteLine($"{absCar.Manufacturer} \n" +
                                        $"-{absCar.Model} \n" +
                                        $"-Price: {absCar.Price}");
                }
                Console.WriteLine("************************");
            }
        }

    }
}
