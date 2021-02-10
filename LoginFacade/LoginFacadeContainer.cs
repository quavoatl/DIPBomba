using System;
using System.Collections.Generic;
using System.Text;
using AuthenticationService;
using AuthorizationService;
using Microsoft.Practices.Unity;
using ValidationService;

namespace LoginFacadeComponent
{
    public class LoginFacadeContainer
    {
        public static LoginFacade RegisterLoginFacade()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ValidationService.ValidationService>();
            unityContainer.RegisterType<AuthenticationService.AuthenticationService>();
            unityContainer.RegisterType<AuthenticationService.AuthenticationService>();

            unityContainer.RegisterType<IValidationService, ValidationService.ValidationService>();
            unityContainer.RegisterType<IAuthenticationService, AuthenticationService.AuthenticationService>();
            unityContainer.RegisterType<IAuthorizationService, AuthorizationService.AuthorizationService>();

            return unityContainer.Resolve<LoginFacade>();
        }
    }
}
