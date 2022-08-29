using System.Collections;
using BuildingBlocks;
using IteratorLibrary.ConceptualExample.Collections;

namespace IteratorLibrary.ConceptualExample;

public static class ConceptualExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Conceptual example");

        // The client code may or may not know about the concrete iterator  or collection classes,
        // depending on the level of indirection you want to keep in your program.
        var collection = new WordsCollection
        {
            "First",
            "Second",
            "Third"
        };

        Console.WriteLine("Straight traversal:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nReverse traversal:");
        collection.ReverseDirection();
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        // It is also possible to pass an iterator to a client class instead of giving it access to a whole collection.
        // This way, you don't expose the collection to the client at all.
        Console.WriteLine("\nReverse traversal using alternative approach:");
        IEnumerator enumerator = collection.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
    }
}
