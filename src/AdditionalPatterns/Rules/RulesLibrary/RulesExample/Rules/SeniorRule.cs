using System;
using RulesLibrary.Common;
using RulesLibrary.RulesExample.Rules.Common;

namespace RulesLibrary.RulesExample.Rules
{
    public class SeniorRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer)
        {
            if (customer.DateOfBirth < DateTime.Now.AddYears(-65))
            {
                return 0.05m;
            }

            return 0;
        }
    }
}
