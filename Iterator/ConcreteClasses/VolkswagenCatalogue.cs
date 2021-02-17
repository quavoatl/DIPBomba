using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Interfaces;

namespace Iterator.ConcreteClasses
{
    public class VolkswagenCatalogue : ICarsCatalogue
    {
        private const int MAX_SIZE = 2;
        private AbstractCar[] _catalogue = new AbstractCar[MAX_SIZE];
        private int _arrayPosition = 0;

        public AbstractCar[] Catalogue { get=> _catalogue; set=> _catalogue = value; }
        public VolkswagenCatalogue()
        {
            addCar(new VolkswagenPassat("Volkswagen","Passat B7", 6750.30));
            addCar(new VolkswagenGolf("Volkswagen", "Golf IV", 1750.30));
        }

        public void addCar(AbstractCar car)
        {
            try
            {
                _catalogue[_arrayPosition] = car;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The list is full or some error occured");
            }
            finally
            {
                _arrayPosition++;
            }
        }

        public ICarCatalogueIterator createIterator()
        {
            return new VolkswagenCarCatalogueIterator(Catalogue);
        }
    }
}
