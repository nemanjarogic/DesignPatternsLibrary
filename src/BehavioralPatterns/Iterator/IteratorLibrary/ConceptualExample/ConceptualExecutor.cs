using System;
using BuildingBlocks;
using IteratorLibrary.ConceptualExample.Collections;

namespace IteratorLibrary.ConceptualExample
{
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
        }
    }
}
