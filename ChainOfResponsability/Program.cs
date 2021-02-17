using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractService carWashService = new CarWashService("Washing your car", 15.5);
            AbstractService carTyresService = new CarTyreService("Fixing your tyres", 20.75);
            AbstractService carEngineTuneService = new CarEngineService("Tuning your engine", 50.25);

            AbstractServiceHandler carTyresHandler = new CarTyresServiceHandler(carTyresService);
            AbstractServiceHandler carEngineTuneHandler = new CarEngineTuneHandler(carEngineTuneService);
            AbstractServiceHandler carWasherHandler = new CarWasherHandler(carWashService);

            AbstractCar toyota = new Toyota("Toyota Avensis 2.2D", new List<AbstractService>(new AbstractService[] { carWashService, carTyresService, carEngineTuneService }));

            List<AbstractServiceHandler> listOfServiceHandlers =
                new List<AbstractServiceHandler>(new AbstractServiceHandler[] { carTyresHandler, carEngineTuneHandler, carWasherHandler });

            ServiceCenter serviceCenter = new ServiceCenter(listOfServiceHandlers);
            serviceCenter.StartServiceProcess(toyota);


        }
    }
}
