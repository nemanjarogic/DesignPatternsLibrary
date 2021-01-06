using DecoratorLibrary.PancakeExample.Components.Common;

namespace DecoratorLibrary.PancakeExample.Components
{
    public class SmallPancake : Pancake
    {
        public SmallPancake()
        {
            Description = "Small pancake";
        }

        public override double CalculatePrice()
        {
            return 6.0;
        }
    }
}
