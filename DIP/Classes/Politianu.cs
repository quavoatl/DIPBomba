using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes
{
    class Politianu : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool VerificaPulaiDePermis(PersoanaCuPermisacio person)
        {
            foreach (Enums.CategoriePermis categ in Enum.GetValues(typeof(Enums.CategoriePermis)))
            {
                if (person.Carnet.CategoriiDetinute.Contains(categ)) return true;
            }

            return false;
        }
    }

}
