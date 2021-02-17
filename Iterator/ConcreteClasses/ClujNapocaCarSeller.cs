using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Interfaces;

namespace Iterator.ConcreteClasses
{
    public class ClujNapocaCarSeller : AbstractCarSeller
    {
        public ClujNapocaCarSeller(string name, string company, IList<ICarCatalogueIterator> carCatalogueIterators) : base(name, company, carCatalogueIterators) { }
    }
}
