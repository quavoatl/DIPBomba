using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interfaces
{
    interface IPolitianu : IPerson
    {
        void VerificaPulaiDePermis(IDrivePerson person);
    }
}
