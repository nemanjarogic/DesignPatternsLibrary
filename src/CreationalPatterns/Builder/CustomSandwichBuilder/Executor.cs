using CustomSandwichBuilder.Builders;
using CustomSandwichBuilder.Directors;
using DesignPatternsLibrary.PatternExecutors;

namespace CustomSandwichBuilder
{
    /// <summary>
    /// The Client must associate one of the builder objects with the director.
    /// Usually, it’s done just once, via parameters of the director’s constructor.
    /// Then the director uses that builder object for all further construction.
    /// However, there’s an alternative approach for when the client passes the builder object
    /// to the production method of the director.
    /// In this case, you can use a different builder each time you produce something with the director.
    /// </summary>
    public class Executor : PatternExecutor
    {
        public override string Name => "Builder - Creational Pattern";

        public override void Execute()
        {
            var cheapSandwichBuilder = new CheapSandwichBuilder();
            var premiumSandwichBuilder = new PremiumSandwichBuilder();

            var director = new SandwichDirector(cheapSandwichBuilder);

            MakeAndDisplaySandwich(director);

            // This is not common to see, but it is possible to change builder if necessary.
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
