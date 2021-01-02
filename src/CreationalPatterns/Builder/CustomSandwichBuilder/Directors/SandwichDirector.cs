using CustomSandwichBuilder.Builders.Common;
using CustomSandwichBuilder.Products;

namespace CustomSandwichBuilder.Directors
{
    public class SandwichDirector
    {
        private SandwichBuilder _builder;

        public SandwichDirector(SandwichBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(SandwichBuilder newBuilder)
        {
            _builder = newBuilder;
        }

        public void MakeSandwich()
        {
            _builder.CreateNewSandwich();
            _builder.PrepareBread();
            _builder.ApplyMeatAndCheese();
            _builder.ApplyVegetables();
            _builder.AddCondiments();
        }

        public Sandwich GetSandwhich()
        {
            return _builder.GetSandwich();
        }
    }
}
