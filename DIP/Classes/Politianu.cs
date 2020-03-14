using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes
{
    class Politianu : IPolitianu
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Politianu()
        {
            
        }

        public void CumparaVehicul(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void VerificaPulaiDePermis(IDrivePerson person)
        {
            if (person._Carnet.CategoriiDetinute.Contains(person.VehiculCurent.CategoriePermisNecesara))
            {
                Console.WriteLine("Coaie conduci bine no stress");
            }
            else
            {
                Console.WriteLine("Bafta coaie dosar penal");
            }
        }

    }

}
