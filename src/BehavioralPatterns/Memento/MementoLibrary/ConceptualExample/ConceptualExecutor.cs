using BuildingBlocks;

namespace MementoLibrary.ConceptualExample;

public static class ConceptualExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Conceptual example");

        var originator = new Originator("Initial state.");
        var caretaker = new Caretaker(originator);
        caretaker.Backup();

        originator.DoSomething();
        caretaker.Backup();

        originator.DoSomething();
        caretaker.Backup();

        caretaker.ShowHistory();

        originator.DoSomething();

        Console.WriteLine("\nClient: Now, let's rollback!\n");
        caretaker.Undo();

        Console.WriteLine("\n\nClient: Rollback once more!\n");
        caretaker.Undo();
    }
}
