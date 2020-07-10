using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class CarWasherHandler : AbstractServiceHandler
    {
        public CarWasherHandler(AbstractService service, AbstractServiceHandler nextServiceHandler = null) : base(service, nextServiceHandler) { }

    }
}
