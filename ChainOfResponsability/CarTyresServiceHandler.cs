using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class CarTyresServiceHandler : AbstractServiceHandler
    {
        public CarTyresServiceHandler(AbstractService service, AbstractServiceHandler nextServiceHandler = null) : base(service, nextServiceHandler) { }

    }
}
