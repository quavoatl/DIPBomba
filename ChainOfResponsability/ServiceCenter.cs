using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class ServiceCenter
    {
        private List<AbstractServiceHandler> _listOfServiceHandlers;
        public List<AbstractServiceHandler> ListOfServiceHandlers
        {
            get { return _listOfServiceHandlers; }
            private set { _listOfServiceHandlers = value; }
        }

        public ServiceCenter(List<AbstractServiceHandler> listOfServiceHandlers)
        {
            _listOfServiceHandlers = listOfServiceHandlers;
            SetChainOfServices();
        }

        public void StartServiceProcess(AbstractCar car)
        {
            _listOfServiceHandlers[0].Service(car);
            if (car.IsServiceComplete()) Console.WriteLine("Service done");
        }

        private void SetChainOfServices()
        {
            for (int i = 0; i < _listOfServiceHandlers.Count; i++)
            {
                try
                {
                    _listOfServiceHandlers[i].NextServiceHandler = _listOfServiceHandlers[i + 1];
                }
                catch (ArgumentOutOfRangeException ex) { _listOfServiceHandlers[i].NextServiceHandler = null; }
            }
        }

        public void DisplayServicesBill(AbstractCar car)
        {
            double totalPrice = 0;
            foreach (var service in car.ServicesRequired)
            {
                totalPrice += service.Price;
            }

            Console.WriteLine($"Total cost for your car service is {totalPrice}");
        }

    }
}
