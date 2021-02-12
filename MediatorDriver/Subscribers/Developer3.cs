using System;
using System.Collections.Generic;
using System.Text;
using MediatorDriver.Mediator;

namespace MediatorDriver.Subscribers
{
    public class Developer3 : IColleague
    {
        private ISystemMediator _mediator;
        private string TriggerKeyword = "hiring json";
        private string CollegueName = "Developer3";

        private void ProcessRequest(string request)
        {
            if (request.Contains(TriggerKeyword)) Console.WriteLine($"{CollegueName} processed the request: {TriggerKeyword} processed");
        }

        public Developer3(ISystemMediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterColleague(this);
        }

        public void ReceiveRequest(string request)
        {
            Console.WriteLine($"{CollegueName} received the request: {request}");
            ProcessRequest(request);
        }

        public void SendRequest(string request)
        {
            _mediator.HandleRequest(this, request);
        }
    }
}
