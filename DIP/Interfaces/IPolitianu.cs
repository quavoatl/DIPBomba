using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interfaces {
    interface IPolitianu : IPerson {
        bool CheckLicense(IDrivePerson person, Vehicle vehicle);
    }
}
