using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeImplementation.PaymentProcessor
{
    public class CitiBankPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("CitiBank");
        }
    }
}
