using System;
using System.Collections.Generic;
using System.Text;

namespace DIP{
    public class License {
        private SortedSet<LicenseCategory> ownedCategories;

        public SortedSet<LicenseCategory> OwnedCategories
        {
            get => ownedCategories;
            set => ownedCategories = value;
        }

        public License()
        { // varargs of enum value in constructor -- cannot have carnet with no categories
           
        }
    }

    public enum LicenseCategory // repetition
    {
        Masina,
        Caruta,
        TIR
    }


}
