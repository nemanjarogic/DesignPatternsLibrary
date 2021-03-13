using System;
using BuildingBlocks;
using IteratorLibrary.MusicFestivalsExample.Collections;
using IteratorLibrary.MusicFestivalsExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalsExample
{
    public static class MusicFestivalsExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Music festivals example");

            var collection = new FestivalCollection();

            collection.Add(new MusicFestival("EXIT", "Serbia"));
            collection.Add(new MusicFestival("Tomorrowland", "Belgium"));
            collection.Add(new MusicFestival("Glastonbury", "UK"));
            collection.Add(new MusicFestival("Coachella", "USA"));
            collection.Add(new MusicFestival("Woodstock", "USA"));

            var iterator = collection.CreateIterator();

            Console.WriteLine("Initial traversal.");
            Traverse(iterator);

            iterator.Reset();
            iterator.Step = 2;

            Console.WriteLine("\nSecond traversal that should skip every other element.");
            Traverse(iterator);
        }

        private static void Traverse(IIterator iterator)
        {
            while (iterator.MoveNext())
            {
                MusicFestival festival = iterator.Current();
                Console.WriteLine($"Music festival {festival.Name} takes place in {festival.Country}.");
            }
        }
    }
}
