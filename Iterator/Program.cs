using System;
using Iterator.ConcreteClasses;
using Iterator.Interfaces;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarsCatalogue volkswagenCatalogue = new VolkswagenCatalogue();
            ICarsCatalogue toyotaCatalogue = new ToyotaCatalogue();

            ICarCatalogueIterator vwCarsIterator = volkswagenCatalogue.createIterator();
            ICarCatalogueIterator toyotaCarsIterator = toyotaCatalogue.createIterator();

            AbstractCarSeller seller = new ClujNapocaCarSeller("Ionut", "Cacat SRL", new ICarCatalogueIterator[] { vwCarsIterator, toyotaCarsIterator });
            seller.GetCarsInformation();
        }
    }
}
