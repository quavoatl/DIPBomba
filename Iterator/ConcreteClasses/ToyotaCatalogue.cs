using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Interfaces;

namespace Iterator.ConcreteClasses
{
    public class ToyotaCatalogue : ICarsCatalogue
    {
        private IList<AbstractCar> _toyotaCatalogueList;
        public IList<AbstractCar> ToyotaCatalogueList { get => _toyotaCatalogueList; set=> _toyotaCatalogueList = value ; }

        public ToyotaCatalogue()
        {
            _toyotaCatalogueList = new List<AbstractCar>();
            _toyotaCatalogueList.Add(new ToyotaAvensis("Toyota", "Avensis 3", 3123));
            _toyotaCatalogueList.Add(new ToyotaYaris("Toyota", "Yaris 2012", 6633));
        }


        public void addCar(AbstractCar car)
        {
            _toyotaCatalogueList.Add(car);
        }

        public ICarCatalogueIterator createIterator()
        {
            return new ToyotaCarCatalogueIterator(_toyotaCatalogueList);
        }
    }
}
