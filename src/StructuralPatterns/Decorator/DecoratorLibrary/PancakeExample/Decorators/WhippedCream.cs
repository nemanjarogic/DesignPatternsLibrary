using DecoratorLibrary.PancakeExample.Components.Common;
using DecoratorLibrary.PancakeExample.Decorators.Common;

namespace DecoratorLibrary.PancakeExample.Decorators;

public class WhippedCream : PancakeDecorator
{
    public WhippedCream(Pancake pancake)
        : base(pancake)
    {
        Description = "Whipped cream";
    }

    public override double CalculatePrice() => base.CalculatePrice() + 0.4;
}
