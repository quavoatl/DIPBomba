using System;
using System.Collections.Generic;
using System.Text;
using BridgeImplementation.PaymentProcessor;

namespace BridgeImplementation.PaymentTypeComponent
{
    interface IPaymentType
    { 
        IPaymentProcessor PaymentProcessor { get; set; }
        void MakeAPayment();
    }
}
