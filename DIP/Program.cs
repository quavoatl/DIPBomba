using System;
using DIP.Classes;
using DIP.Interfaces;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson persoanaCuPermisacio = Factory.CreateAPerson(PersonType.Simple);
            persoanaCuPermisacio.Name = "Laurentiu din Ciuperceni";
            IAuthorizedPerson persoanaAutorizata = Factory.CreateAnAuthorizedPerson(PersonType.LicenseCreator);

            // Even if the type of persoanaAutorizata is declared as IPerson, its actual type is of the subclass
            // The idea of dependency inversion is to rely on the abstraction instead of an implementation, and that's only partially correct here. 
            // Don't actually cast the variable into a different type, leave the type as abstract as possible for your functionality to still work correctly;

           // persoanaAutorizata.CreateALicense(persoanaCuPermisacio,LicenseCategory.Masina);

            Vehicle vehicle = Factory.CreateAVehicle(VehicleTypes.Audi);
            persoanaCuPermisacio.BuyVehicle(vehicle); // people can buy vehicles without owning the proper license : V
                                                                // people can buy more than one vehicle : V
                                                                // during a check, the polis doesn't check all vehicles, but the one the person is in : V


            IPoliceman politianu = Factory.CreateAPoliceman(PersonType.Policeman); // invert the dependency : bun asa sau ? 
            persoanaCuPermisacio.Drive(vehicle);


            politianu.VerifyVehicleLicense(persoanaCuPermisacio); // you're interested in a combination of a car and a person, not what the person currently owns : V
        }
    }
}
