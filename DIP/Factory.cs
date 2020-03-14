using System;
using System.Collections.Generic;
using System.Text;
using DIP.Classes;
using DIP.Interfaces;

namespace DIP
{
    public static class Factory
    {
        public static IPerson CreateAPerson(Enums.PersonType persoana)
        {
            switch (persoana)
            {
                case Enums.PersonType.PersoanaCuPermis: return new PersoanaCuPermisacio(Factory.CreateACarnet());
                case Enums.PersonType.SimplePerson: return new SimplePerson();
                case Enums.PersonType.Politianu: return new Politianu();
                case Enums.PersonType.PersoanaAutorizata: return new PersoanaAutorizata();

                default: return new SimplePerson();
            }
        }

        public static Carnet CreateACarnet()
        {
            return new Carnet();
        }

        public static Vehicle CreateAVehicle(Enums.ModeleVehicule vehicul)
        {
            switch (vehicul)
            {
                case Enums.ModeleVehicule.SotoCaruta: return new Vehicle(Enums.ModeleVehicule.SotoCaruta) { CategoriePermisNecesara = Enums.CategoriePermis.Caruta };

                case Enums.ModeleVehicule.Audi: return new Vehicle(Enums.ModeleVehicule.Audi) { CategoriePermisNecesara = Enums.CategoriePermis.Masina };

                case Enums.ModeleVehicule.Toyota: return new Vehicle(Enums.ModeleVehicule.Toyota) { CategoriePermisNecesara = Enums.CategoriePermis.Masina };

                case Enums.ModeleVehicule.TIRVolvo: return new Vehicle(Enums.ModeleVehicule.TIRVolvo) { CategoriePermisNecesara = Enums.CategoriePermis.TIR };

                default: return new Vehicle(Enums.ModeleVehicule.SotoCaruta) { CategoriePermisNecesara = Enums.CategoriePermis.Caruta };
            }
        }
    }
}
