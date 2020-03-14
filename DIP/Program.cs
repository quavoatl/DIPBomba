using System;
using DIP.Classes;
using DIP.Interfaces;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrivePerson persoanaCuPermisacio = (IDrivePerson)Factory.CreateAPerson(Enums.PersonType.PersoanaCuPermis); // invert the dependency : bun asa sau ? 
            IAuthorizedPerson persoanaAutorizata = (IAuthorizedPerson)Factory.CreateAPerson(Enums.PersonType.PersoanaAutorizata);      // invert the dependency : bun asa sau ? 


            persoanaAutorizata.BagaCategorieInPermis(persoanaCuPermisacio, Enums.CategoriePermis.Masina);

            Vehicle TiranuVolvanu = Factory.CreateAVehicle(Enums.ModeleVehicule.TIRVolvo);
            persoanaCuPermisacio.CumparaVehicul(TiranuVolvanu); // people can buy vehicles without owning the proper license : V
                                                                // people can buy more than one vehicle : V
                                                                // during a check, the polis doesn't check all vehicles, but the one the person is in : V


            IPolitianu politianu = (IPolitianu)Factory.CreateAPerson(Enums.PersonType.Politianu); // invert the dependency : bun asa sau ? 
            persoanaCuPermisacio.Drive(TiranuVolvanu);


            politianu.VerificaPulaiDePermis(persoanaCuPermisacio); // you're interested in a combination of a car and a person, not what the person currently owns : V
        }
    }
}
