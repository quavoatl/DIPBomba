using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeImplementation.PaymentProcessor
{
    public class OtherBankPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("OtherBankPaymentProcessor");
        }
    }
}
