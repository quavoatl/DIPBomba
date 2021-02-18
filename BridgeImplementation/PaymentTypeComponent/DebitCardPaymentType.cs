using System;
using System.Collections.Generic;
using System.Text;
using BridgeImplementation.PaymentProcessor;

namespace BridgeImplementation.PaymentTypeComponent
{
    public class DebitCardPaymentType : IPaymentType
    {
        public IPaymentProcessor PaymentProcessor { get; set; }

        public DebitCardPaymentType(IPaymentProcessor paymentProcessor)
        {
            PaymentProcessor = paymentProcessor;
        }

        public void MakeAPayment()
        {
           Console.WriteLine("Payment via Debit Card - Processor: ");
           PaymentProcessor.ProcessPayment();
        }
    }
}
