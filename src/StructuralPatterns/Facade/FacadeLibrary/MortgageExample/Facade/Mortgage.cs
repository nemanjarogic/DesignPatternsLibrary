using System;
using FacadeLibrary.MortgageExample.Subsystem;

namespace FacadeLibrary.MortgageExample.Facade
{
    public class Mortgage
    {
        private readonly Bank _bank;
        private readonly Loan _loan;
        private readonly Credit _credit;
        private readonly CustomerService _customerService;

        public Mortgage()
        {
            _bank = new Bank();
            _loan = new Loan();
            _credit = new Credit();
            _customerService = new CustomerService();
        }

        public bool IsEligible(string customerName, decimal loanAmount)
        {
            Console.WriteLine($"Customer {customerName} wants to apply for {loanAmount:C} loan.\n");

            var customer = _customerService.Find(customerName);

            if (_bank.IsUntrustworthy(customer, loanAmount))
            {
                return false;
            }

            if (_loan.HasBadLoans(customer))
            {
                return false;
            }

            if (_credit.HasBadCredit(customer))
            {
                return false;
            }

            return true;
        }
    }
}
