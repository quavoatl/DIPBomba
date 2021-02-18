using System;
using BridgeImplementation.PaymentProcessor;
using BridgeImplementation.PaymentTypeComponent;

namespace BridgeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentType paymentType = new DebitCardPaymentType(new CitiBankPaymentProcessor());
            paymentType.MakeAPayment();
        }
    }
}
