using System;
using RulesLibrary.Common;
using RulesLibrary.RulesExample.Rules.Common;

namespace RulesLibrary.RulesExample.Rules
{
    public class LoyalCustomerRule : IDiscountRule
    {
        private readonly int _requiredYearsAsCustomer;
        private readonly decimal _discount;

        public LoyalCustomerRule(int requiredYearsAsCustomer, decimal discount)
        {
            _requiredYearsAsCustomer = requiredYearsAsCustomer;
            _discount = discount;
        }

        public decimal CalculateDiscount(Customer customer)
        {
            if (customer.DateOfFirstPurchase.HasValue)
            {
                if (customer.DateOfFirstPurchase.Value.AddYears(_requiredYearsAsCustomer) <= DateTime.Today)
                {
                    var birthdayRule = new BirthdayDiscountRule();
                    return _discount + birthdayRule.CalculateDiscount(customer);
                }
            }

            return 0;
        }
    }
}
