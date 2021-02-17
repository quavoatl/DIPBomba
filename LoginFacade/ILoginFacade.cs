using System;

namespace LoginFacadeComponent
{
    public interface ILoginFacade
    {
        bool CanLogin(string user, string pass);
    }
}
