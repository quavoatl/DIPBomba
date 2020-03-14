using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes {
    class PersoanaAutorizata : IPerson {
        public string Name { get; set; }
        public int Age { get; set; }

        public void BagaCategorieInPermis(IDrivePerson persoanaCuPermisacio, Enums.CategoriePermis categ) {
            persoanaCuPermisacio._Carnet.CategoriiDetinute.Add(categ);
        }

        public void CumparaVehicul(Vehicle vehicle) {
            throw new NotImplementedException();
        }
    }
}
