using System;
using System.Collections.Generic;
using System.Text;
using MediatorDriver.Mediator;

namespace MediatorDriver.Subscribers
{
    public interface IColleague
    {
        void ReceiveRequest(string request);
        void SendRequest(string request);
    }
}
