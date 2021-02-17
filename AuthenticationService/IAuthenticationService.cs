using System;

namespace AuthenticationService
{
    public interface IAuthenticationService
    {
        bool IsUserAuthenticated(string user, string pass);
    }
}
