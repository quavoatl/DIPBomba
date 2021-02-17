using System;

namespace AuthorizationService
{
    public interface IAuthorizationService
    {
        bool IsUserAuthorized(string user, string pass);
    }
}
