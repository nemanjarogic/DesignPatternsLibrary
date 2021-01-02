using CustomSandwichBuilder.Products;

namespace CustomSandwichBuilder.Builders.Common
{
    public abstract class SandwichBuilder
    {
        protected Sandwich _sandwich;

        public Sandwich GetSandwich()
        {
            return _sandwich;
        }

        public abstract void CreateNewSandwich();

        public abstract void PrepareBread();

        public abstract void ApplyMeatAndCheese();

        public abstract void ApplyVegetables();

        public abstract void AddCondiments();
    }
}
