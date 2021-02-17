using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizationService
{
    public class AuthorizationService : IAuthorizationService
    {
        public bool IsUserAuthorized(string user, string pass)
        {
            if (user.Equals("marean") && pass.Equals("123")) return true;
            return false;
        }
    }
}
