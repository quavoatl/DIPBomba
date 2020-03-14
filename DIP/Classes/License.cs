using System;
using System.Collections.Generic;
using System.Text;

namespace DIP{
    public class License {
        public SortedSet<Enums.CategoriePermis> categoriiDetinute;
        public Carnet() { // varargs of enum value in constructor -- cannot have carnet with no categories
            CategoriiDetinute = new SortedSet<Enums.CategoriePermis>();
        }
    }

    public enum CategoriePermis // repetition
    {
        Masina,
        Caruta,
        TIR
    }
}
