using System;
using System.Collections.Generic;
using System.Text;
using BridgeImplementation.PaymentProcessor;

namespace BridgeImplementation.PaymentTypeComponent
{
    public class OnAccountPaymentType : IPaymentType
    {
        public IPaymentProcessor PaymentProcessor { get; set; }

        public OnAccountPaymentType(IPaymentProcessor paymentProcessor)
        {
            PaymentProcessor = paymentProcessor;
        }

        public void MakeAPayment()
        {
           Console.WriteLine("Payment via On Account - Processor: ");
           PaymentProcessor.ProcessPayment();
        }
    }
}
