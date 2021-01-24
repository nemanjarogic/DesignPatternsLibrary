using BuildingBlocks;
using StateLibrary.ConceptualExample;
using StateLibrary.ConceptualExample.States;

namespace ObserverLibrary.StockExample
{
    public static class ConceptualExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Conceptual example");

            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}
