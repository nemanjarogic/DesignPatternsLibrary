using System;
using System.Collections.Generic;
using RulesLibrary.Common;
using RulesLibrary.RulesExample.Rules;
using RulesLibrary.RulesExample.Rules.Common;

namespace RulesLibrary.RulesExample
{
    /// <summary>
    /// In this implementation of discount calculator individual rules are separated.
    /// New rules can be added without the need to change the rest of the system.
    /// </summary>
    public class DiscountCalculator
    {
        private readonly List<IDiscountRule> _rules;

        public DiscountCalculator()
        {
            // Rules can be injected or configured manually by clients too.
            _rules = new List<IDiscountRule>
            {
                new BirthdayDiscountRule(),
                new SeniorRule(),
                new VeteranRule(),
                new LoyalCustomerRule(1, 0.10m),
                new LoyalCustomerRule(5, 0.12m),
                new LoyalCustomerRule(10, 0.20m),
                new FirstPurchaseRule(),
            };
        }

        public decimal Calculate(Customer customer)
        {
            decimal discount = 0;

            foreach (var rule in _rules)
            {
                var proposedDiscount = rule.CalculateDiscount(customer);
                discount = Math.Max(proposedDiscount, discount);
            }

            return discount;
        }
    }
}
