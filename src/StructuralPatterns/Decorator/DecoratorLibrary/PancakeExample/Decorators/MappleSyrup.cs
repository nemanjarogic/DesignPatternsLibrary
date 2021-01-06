using DecoratorLibrary.PancakeExample.Components.Common;
using DecoratorLibrary.PancakeExample.Decorators.Common;

namespace DecoratorLibrary.PancakeExample.Decorators
{
    public class MappleSyrup : PancakeDecorator
    {
        public MappleSyrup(Pancake pancake)
            : base(pancake)
        {
            Description = "Mapple syrup";
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 1.0;
        }
    }
}
