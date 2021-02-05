using System;
using RulesLibrary.Common;
using RulesLibrary.RulesExample.Rules.Common;

namespace RulesLibrary.RulesExample.Rules
{
    public class BirthdayDiscountRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer)
        {
            if (customer.DateOfBirth.Month == DateTime.Today.Month &&
                customer.DateOfBirth.Day == DateTime.Today.Day)
            {
                return 0.10m;
            }

            return 0;
        }
    }
}
