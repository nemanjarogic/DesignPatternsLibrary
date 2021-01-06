using DecoratorLibrary.PancakeExample.Components.Common;

namespace DecoratorLibrary.PancakeExample.Components
{
    public class BigPancake : Pancake
    {
        public BigPancake()
        {
            Description = "Big pancake";
        }

        public override double CalculatePrice()
        {
            return 10.0;
        }
    }
}
