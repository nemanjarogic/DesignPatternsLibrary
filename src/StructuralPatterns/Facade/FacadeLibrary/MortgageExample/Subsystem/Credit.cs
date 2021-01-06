using System;

namespace FacadeLibrary.MortgageExample.Subsystem
{
    public class Credit
    {
        public bool HasBadCredit(Customer customer)
        {
            Console.WriteLine($"Check credit for customer: {customer.Name}");

            return false;
        }
    }
}
