using RulesLibrary.Common;
using RulesLibrary.RulesExample.Rules.Common;

namespace RulesLibrary.RulesExample.Rules
{
    public class VeteranRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer)
        {
            if (customer.IsVeteran)
            {
                return 0.10m;
            }

            return 0;
        }
    }
}
