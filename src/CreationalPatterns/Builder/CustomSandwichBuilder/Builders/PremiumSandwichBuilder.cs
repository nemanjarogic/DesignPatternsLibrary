using CustomSandwichBuilder.Builders.Common;
using CustomSandwichBuilder.Products;
using CustomSandwichBuilder.Products.Enums;
using System.Collections.Generic;

namespace CustomSandwichBuilder.Builders
{
    /// <summary>
    /// Concrete Builders provide different implementations of the construction steps.
    /// Note that concrete builders may produce products that don't follow the common interface.
    /// </summary>
    public class PremiumSandwichBuilder : SandwichBuilder
    {
        public override void CreateNewSandwich()
        {
            _sandwich = new Sandwich("Premium sandwich");
        }

        public override void AddCondiments()
        {
            _sandwich.HasMustard = true;
            _sandwich.HasMayonnaise = true;
            _sandwich.HasKetchup = true;
        }

        public override void ApplyMeatAndCheese()
        {
            _sandwich.MeatType = MeatType.Beef;
            _sandwich.CheeseType = CheeseType.Pule;
        }

        public override void ApplyVegetables()
        {
            _sandwich.Vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
        }

        public override void PrepareBread()
        {
            _sandwich.BreadType = BreadType.WholeGrain;
        }
    }
}
