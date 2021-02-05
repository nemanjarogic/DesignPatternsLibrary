using System;
using RulesLibrary.Common;

namespace RulesLibrary.MotivatingExample
{
    /// <summary>
    /// In this implementation of discount calculator we can
    /// see complex business logic that is hard to understand.
    /// Additional changes of the same nature are likely to happen and introduce new problems.
    /// </summary>
    public class DiscountCalculator
    {
        public decimal Calculate(Customer customer)
        {
            decimal discount = 0;
            DateTime currentDate = DateTime.Now;

            if (customer.DateOfBirth < currentDate.AddYears(-65))
            {
                // Senior discount of 5%
                discount = 0.05m;
            }

            if (customer.DateOfFirstPurchase.HasValue)
            {
                if (customer.DateOfFirstPurchase.Value < currentDate.AddYears(-1))
                {
                    // After 1 year, loyal customers get 10% discount
                    discount = Math.Max(discount, 0.10m);
                    if (customer.DateOfFirstPurchase.Value < currentDate.AddYears(-5))
                    {
                        // After 5 years, loyal customers get 12% discount
                        discount = Math.Max(discount, 0.12m);
                        if (customer.DateOfFirstPurchase.Value < currentDate.AddYears(-10))
                        {
                            // After 10 years, loyal customers get 20% discount
                            discount = Math.Max(discount, 0.20m);
                        }
                    }

                    if (customer.DateOfBirth.Month == DateTime.Today.Month &&
                        customer.DateOfBirth.Day == DateTime.Today.Day)
                    {
                        // Loyal customers can get an additional 10% discount
                        // if they purchase a product on their birthday
                        discount += 0.10m;
                    }
                }
            }
            else
            {
                // First time purchase discount of 15%
                discount = Math.Max(discount, 0.15m);
            }

            if (customer.IsVeteran)
            {
                // Veterans get 10% discount
                discount = Math.Max(discount, 0.10m);
            }

            return discount;
        }
    }
}
