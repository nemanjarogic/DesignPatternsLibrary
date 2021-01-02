using CustomSandwichBuilder.Builders.Common;
using CustomSandwichBuilder.Products;
using CustomSandwichBuilder.Products.Enums;
using System.Collections.Generic;

namespace CustomSandwichBuilder.Builders
{
    public class CheapSandwichBuilder : SandwichBuilder
    {
        public override void CreateNewSandwich()
        {
            _sandwich = new Sandwich("Cheap sandwich");
        }

        public override void AddCondiments()
        {
            _sandwich.HasMayonnaise = true;
        }

        public override void ApplyMeatAndCheese()
        {
            _sandwich.MeatType = MeatType.Salami;
            _sandwich.CheeseType = CheeseType.Cheddar;
        }

        public override void ApplyVegetables()
        {
            _sandwich.Vegetables = new List<string> { "Tomato" };
        }

        public override void PrepareBread()
        {
            _sandwich.BreadType = BreadType.White;
        }
    }
}
