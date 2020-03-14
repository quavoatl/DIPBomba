using System;
using System.Collections.Generic;
using System.Text;
using DIP.Classes;
using DIP.Interfaces;

namespace DIP
{
    public static class Factory
    {
        public static IPerson CreateAPerson(PersonType person)
        {
            switch (person)
            {
                case PersonType.CarDriver: return new CarDriverPerson();
                case PersonType.Simple: return new SimplePerson();

                default: return new SimplePerson();
            }
        }

        public static IAuthorizedPerson CreateAnAuthorizedPerson(PersonType person)
        {
            switch (person)
            {
                case PersonType.CarDriver: return new LicenseCreator();
                //future types of authorizedPerson maybe ServiceRepair?
                default: return new LicenseCreator();
            }
        }

        public static IPoliceman CreateAPoliceman(PersonType person)
        {
            switch (person)
            {
                case PersonType.Policeman: return new CarLicenseVerificationPolice();
                //future types of IPoliceman maybe IDVerificationPolice ?
                default: return new CarLicenseVerificationPolice();
            }
        }

        public static License CreateBruteLicense()
        {
            return new License();
        }

        public static Vehicle CreateAVehicle(VehicleTypes vehicul)
        {
            switch (vehicul)
            {
                case VehicleTypes.SotoCaruta:
                    return new Vehicle(VehicleTypes.SotoCaruta)
                    { _NeccessaryCategory = LicenseCategory.Caruta };

                case VehicleTypes.Audi:
                    return new Vehicle(VehicleTypes.Audi)
                    { _NeccessaryCategory = LicenseCategory.Masina };

                case VehicleTypes.Toyota:
                    return new Vehicle(VehicleTypes.Toyota)
                    { _NeccessaryCategory = LicenseCategory.Masina };

                case VehicleTypes.TIRVolvo:
                    return new Vehicle(VehicleTypes.TIRVolvo)
                    { _NeccessaryCategory = LicenseCategory.TIR };

                default:
                    return new Vehicle(VehicleTypes.SotoCaruta)
                    { _NeccessaryCategory = LicenseCategory.Caruta };
            }
        }
    }
}
