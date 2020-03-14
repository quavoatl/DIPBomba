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
            // don't write switch cases without default cases
            switch (persoana) 
            {
                case Enums.PersonType.PersoanaCuPermis: return new PersoanaCuPermisacio(Factory.CreateACarnet());
                case Enums.PersonType.SimplePerson: return new SimplePerson();
                case Enums.PersonType.Politianu: return new Politianu();
                case Enums.PersonType.PersoanaAutorizata: return new PersoanaAutorizata();
            }
            return null; // never return null
        }

        public static Vehicle CreateAVehicle(Enums.VehiculDetinut vehicul)
        {
            return new Vehicle(vehicul);
        }

        public static Carnet CreateACarnet()
        {
            return new Carnet();
        }
        
    }
}
