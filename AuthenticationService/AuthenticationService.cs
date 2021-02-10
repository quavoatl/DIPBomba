using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool IsUserAuthenticated(string user, string pass)
        {
            if (user.Equals("marean") && pass.Equals("123")) return true;
            return false;
        }
    }
}
