using System;
using System.Collections.Generic;
using System.Text;
using AuthenticationService;
using AuthorizationService;
using ValidationService;

namespace LoginFacadeComponent
{
    public class LoginFacade : ILoginFacade
    {
        private IValidationService _validationService;
        private IAuthenticationService _authenticationService;
        private IAuthorizationService _authorizationService;

        public LoginFacade(IValidationService validationService, IAuthenticationService authenticationService, IAuthorizationService authorizationService)
        {
            _validationService = validationService;
            _authenticationService = authenticationService;
            _authorizationService = authorizationService;
        }

        public bool CanLogin(string user, string pass)
        {
            return _validationService.IsUserValid(user, pass) &&
                   _authenticationService.IsUserAuthenticated(user, pass) &&
                   _authenticationService.IsUserAuthenticated(user, pass);
        }
    }
}
