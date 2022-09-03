using BuildingBlocks;
using StateLibrary.ConceptualExample.States;

namespace StateLibrary.ConceptualExample;

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
