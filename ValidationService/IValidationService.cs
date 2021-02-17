using System;

namespace ValidationService
{
    public interface IValidationService
    {
        bool IsUserValid(string user, string pass);
    }
}
