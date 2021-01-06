using DecoratorLibrary.PancakeExample.Components.Common;
using DecoratorLibrary.PancakeExample.Decorators.Common;

namespace DecoratorLibrary.PancakeExample.Decorators
{
    public class Nutella : PancakeDecorator
    {
        public Nutella(Pancake pancake)
            : base(pancake)
        {
            Description = "Nutella";
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 0.7;
        }
    }
}
