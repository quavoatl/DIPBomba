using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationService
{
    public class ValidationService : IValidationService
    {
        public bool IsUserValid(string user, string pass)
        {
            if (user.Equals("marean") && pass.Equals("123")) return true;
            return false;
        }
    }
}
