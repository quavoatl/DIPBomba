using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability.Interfaces
{
    public abstract class AbstractServiceHandler
    {
        public AbstractService SpecializedService { get; set; }
        public AbstractServiceHandler NextServiceHandler { get; set; }

        public AbstractServiceHandler(AbstractService service, AbstractServiceHandler nextServiceHandler = null)
        {
            SpecializedService = service;
            NextServiceHandler = nextServiceHandler;
        }

        public void Service(AbstractCar car)
        {
            bool carDone = car.IsServiceComplete();

            if (!carDone)
            {
                if (car.ServicesRequired.Contains(SpecializedService))
                {
                    Console.WriteLine($"{this.GetType().Name} doing {SpecializedService.Name}");
                    car.ServicesRequired.Remove(SpecializedService);
                }
                try { NextServiceHandler.Service(car); }
                catch (NullReferenceException ex) { }
            }
        }
    }
}
