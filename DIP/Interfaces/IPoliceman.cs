using DIP.Interfaces;

namespace DIP.Classes
{
    public interface IPoliceman : IPerson
    {
        void VerifyVehicleLicense(IPerson person);
    }
}