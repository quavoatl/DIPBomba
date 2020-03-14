using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interfaces
{
    public interface IAuthorizedPerson : IPerson
    {
        void CreateALicense(IPerson person, LicenseCategory categ);
        void AddCategoryToLicense(IPerson person, LicenseCategory categ);
    }
}
