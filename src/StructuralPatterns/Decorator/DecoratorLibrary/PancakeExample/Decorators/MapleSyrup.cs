using DecoratorLibrary.PancakeExample.Components.Common;
using DecoratorLibrary.PancakeExample.Decorators.Common;

namespace DecoratorLibrary.PancakeExample.Decorators;

public class MapleSyrup : PancakeDecorator
{
    public MapleSyrup(Pancake pancake)
        : base(pancake)
    {
        Description = "Maple syrup";
    }

    public override double CalculatePrice() => base.CalculatePrice() + 1.0;
}
