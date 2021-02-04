using System;

namespace OrderProcessing
{
    public class PaymentProcessor
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment processor: Processing payment...");
            return amount <= 100;
        }
    }
}
