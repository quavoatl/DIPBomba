using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class CarEngineTuneHandler : AbstractServiceHandler
    {
        public CarEngineTuneHandler(AbstractService service, AbstractServiceHandler nextServiceHandler = null) : base(service, nextServiceHandler) { }

    }
}
