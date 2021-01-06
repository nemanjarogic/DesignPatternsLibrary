using DecoratorLibrary.PancakeExample.Components.Common;
using DecoratorLibrary.PancakeExample.Decorators.Common;

namespace DecoratorLibrary.PancakeExample.Decorators
{
    public class MixedBerries : PancakeDecorator
    {
        public MixedBerries(Pancake pancake)
            : base(pancake)
        {
            Description = "Mixed berries";
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 2.0;
        }
    }
}
