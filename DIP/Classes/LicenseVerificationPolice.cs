using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes
{
    class CarLicenseVerificationPolice : IPoliceman
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public License? License { get; set; }
        public List<Vehicle>? Vehicles { get; set; }
        public Vehicle? Vehicle { get; set; }

        public void Drive(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void BuyVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }


        public void VerifyVehicleLicense(IPerson person)
        {
            if (person.License == null)
            {
                Console.WriteLine($"Coaie ce dumnezeii ma tii faci da te jos din masina");
                return;
            }
            else if (person.License.OwnedCategories.Contains(person.Vehicle._NeccessaryCategory))
            {
                Console.WriteLine("Coaie conduci bine no stress");
            }
            else
            {
                Console.WriteLine("Nu ai in carnet categorie pentru asa ceva\n" +
                                  "  -\"Bafta coaie dosar penal\"");
            }
        }

    }

}
