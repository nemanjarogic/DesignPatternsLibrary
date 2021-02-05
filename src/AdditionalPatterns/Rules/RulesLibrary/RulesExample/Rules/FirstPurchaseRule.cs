using RulesLibrary.Common;
using RulesLibrary.RulesExample.Rules.Common;

namespace RulesLibrary.RulesExample.Rules
{
    public class FirstPurchaseRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer)
        {
            if (!customer.DateOfFirstPurchase.HasValue)
            {
                return 0.15m;
            }

            return 0;
        }
    }
}
