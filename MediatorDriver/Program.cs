using System;
using MediatorDriver.Mediator;
using MediatorDriver.Subscribers;

namespace MediatorDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            ISystemMediator apiMediator = new ApiMediator();

            IColleague dev1 = new Developer1(apiMediator);
            IColleague dev2 = new Developer2(apiMediator);
            IColleague dev3 = new Developer3(apiMediator);

            dev2.SendRequest("finance json");

        }
    }
}
