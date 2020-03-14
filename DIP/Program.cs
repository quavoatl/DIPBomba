using System;
using DIP.Classes;
using DIP.Interfaces;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            PersoanaCuPermisacio persoanaCuPermisacio = (PersoanaCuPermisacio) Factory.CreateAPerson(Enums.PersonType.PersoanaCuPermis); // invert the dependency
            PersoanaAutorizata persoanaAutorizata = (PersoanaAutorizata)Factory.CreateAPerson(Enums.PersonType.PersoanaAutorizata);      // invert the dependency
            persoanaAutorizata.BagaCategorieInPermis(persoanaCuPermisacio, Enums.CategoriePermis.TIR);

            persoanaCuPermisacio.CumparaVehicul(Enums.VehiculDetinut.TIR); // people can buy vehicles without owning the proper license
                                                                           // people can buy more than one vehicle
                                                                           // during a check, the polis doesn't check all vehicles, but the one the person is in
        
            Politianu politianu = (Politianu) Factory.CreateAPerson(Enums.PersonType.Politianu); // invert the dependency
            politianu.VerificaPulaiDePermis(persoanaCuPermisacio); // you're interested in a combination of a car and a person, not what the person currently owns
        }
    }
}
