using DecoratorLibrary.PancakeExample.Components.Common;

namespace DecoratorLibrary.PancakeExample.Decorators.Common
{
    public class PancakeDecorator : Pancake
    {
        private readonly Pancake _pancake;

        public PancakeDecorator(Pancake pancake)
        {
            _pancake = pancake;
        }

        public override double CalculatePrice()
        {
            return _pancake.CalculatePrice();
        }

        public override string GetDescriptionAndAddIns()
        {
            return $"{_pancake.GetDescriptionAndAddIns()}, {Description}";
        }
    }
}
