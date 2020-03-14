using DIP.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interfaces {
    public interface IPerson {
        public string Name { get; set; }
        public int Age { get; set; }
        public Carnet Carnet { get; set; }
    }

    public enum PersonType // Not necessarily needed
    {
        SimplePerson,
        PersoanaCuPermis,
        Politianu,
        PersoanaAutorizata
    }
}
