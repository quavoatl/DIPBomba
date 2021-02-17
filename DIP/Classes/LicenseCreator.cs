using System;
using System.Collections.Generic;
using System.Text;
using DIP.Interfaces;

namespace DIP.Classes {
    class LicenseCreator : IAuthorizedPerson
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

        public void CreateALicense(IPerson person, LicenseCategory categ)
        {
            person.License = Factory.CreateBruteLicense();
            AddCategoryToLicense(person, categ);
        }

        public void AddCategoryToLicense(IPerson person,LicenseCategory categ)
        {
            if (person.License.OwnedCategories == null)
            {
                person.License.OwnedCategories = new SortedSet<LicenseCategory>();
            }

            if (!person.License.OwnedCategories.Contains(categ))
            {
                person.License.OwnedCategories.Add(categ);
            }
        }
    }
}
