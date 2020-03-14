using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Classes
{
    public class Vehicle
    {
        private Enums.ModeleVehicule vehicul;
        private Enums.CategoriePermis categoriePermisNecesara;

        public Enums.ModeleVehicule Vehicul
        {
            get => vehicul;
            set => vehicul = value;
        }

        public Enums.CategoriePermis CategoriePermisNecesara
        {
            get => categoriePermisNecesara;
            set => categoriePermisNecesara = value;
        }

        public Vehicle(Enums.ModeleVehicule vehicul)
        {
            this.vehicul = Vehicul;
        }

    }
}
