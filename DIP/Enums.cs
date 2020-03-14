using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Enums // place enums where it makes logical sense for them to reside; don't do this, group them by the thing they enumerate
    {
        public enum CategoriePermis // repetition
        {
           Masina,
           Caruta,
           TIR
        }

        public enum ModeleVehicule // repetition
        {
            Toyota,
            Audi,
            TIRVolvo,
            TIRScania,
            SotoCaruta
        }
        
        public enum PersonType // Not necessarily needed
        {
            SimplePerson,
            PersoanaCuPermis,
            Politianu,
            PersoanaAutorizata
        }
    }
}
