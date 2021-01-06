using System;

namespace FacadeLibrary.MortgageExample.Subsystem
{
    public class Bank
    {
        public bool IsUntrustworthy(Customer customer, decimal loanAmount)
        {
            Console.WriteLine($"Check creditworthyness for customer: {customer.Name}");

            return false;
        }
    }
}
