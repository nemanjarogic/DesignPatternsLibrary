using CustomSandwichBuilder.Builders;
using CustomSandwichBuilder.Directors;
using DesignPatternsLibrary.PatternExecutors;

namespace CustomSandwichBuilder
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Builder - Custom Sandwich Builder - Creational Pattern";

        public override void Execute()
        {
            var cheapSandwichBuilder = new CheapSandwichBuilder();
            var premiumSandwichBuilder = new PremiumSandwichBuilder();

            var director = new SandwichDirector(cheapSandwichBuilder);

            MakeAndDisplaySandwich(director);

            director.ChangeBuilder(premiumSandwichBuilder);

            MakeAndDisplaySandwich(director);
        }

        private void MakeAndDisplaySandwich(SandwichDirector director)
        {
            director.MakeSandwich();
            var sandwich = director.GetSandwhich();

            sandwich.Display();
        }
    }
}
