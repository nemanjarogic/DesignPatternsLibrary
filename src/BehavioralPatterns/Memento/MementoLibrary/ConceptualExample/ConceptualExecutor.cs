using System;
using BuildingBlocks;

namespace MementoLibrary.ConceptualExample
{
    public static class ConceptualExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Conceptual example");

            Originator originator = new Originator("Initial state.");
            Caretaker caretaker = new Caretaker(originator);
            caretaker.Backup();

            originator.DoSomething();
            caretaker.Backup();

            originator.DoSomething();
            caretaker.Backup();

            caretaker.ShowHistory();

            originator.DoSomething();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\nClient: Once more!\n");
            caretaker.Undo();
        }
    }
}
