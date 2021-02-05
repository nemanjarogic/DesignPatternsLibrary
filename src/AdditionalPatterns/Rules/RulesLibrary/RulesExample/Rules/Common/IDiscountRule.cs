using RulesLibrary.Common;

namespace RulesLibrary.RulesExample.Rules.Common
{
    public interface IDiscountRule
    {
        decimal CalculateDiscount(Customer customer);
    }
}
