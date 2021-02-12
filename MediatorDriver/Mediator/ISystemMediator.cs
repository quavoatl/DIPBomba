using System;
using System.Collections.Generic;
using System.Text;
using MediatorDriver.Subscribers;

namespace MediatorDriver.Mediator
{
    public interface ISystemMediator
    {
        void HandleRequest(IColleague colleague, string request);
        void RegisterColleague(IColleague col);
    }
}
