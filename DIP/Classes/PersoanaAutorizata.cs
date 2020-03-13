using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes
{
    class PersoanaAutorizata : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void BagaCategorieInPermis(PersoanaCuPermisacio persoanaCuPermisacio,
            Enums.CategoriePermis categ)
        {
            persoanaCuPermisacio.Carnet.CategoriiDetinute.Add(categ);
        }
    }
}
