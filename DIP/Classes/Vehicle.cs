using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Classes
{
    public class Vehicle
    {
        private Enums.VehiculDetinut vehicul;

        public Enums.VehiculDetinut Vehicul
        {
            get => vehicul;
            set => vehicul = value;
        }

        public Vehicle(Enums.VehiculDetinut vehicul)
        {
            this.vehicul = Vehicul;
        }
    }
}
