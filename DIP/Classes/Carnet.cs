using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Carnet
    {
        private SortedSet<Enums.CategoriePermis> categoriiDetinute;

        public SortedSet<Enums.CategoriePermis> CategoriiDetinute
        {
            get => categoriiDetinute;
            set => categoriiDetinute = value;
        }

    }
}
