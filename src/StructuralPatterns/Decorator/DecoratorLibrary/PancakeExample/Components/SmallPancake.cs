using DecoratorLibrary.PancakeExample.Components.Common;

namespace DecoratorLibrary.PancakeExample.Components;

public class SmallPancake : Pancake
{
    public SmallPancake()
    {
        Description = "Small pancake";
    }

    public override double CalculatePrice() => 6.0;
}
