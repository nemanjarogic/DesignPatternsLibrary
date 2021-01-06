using System;

namespace BuildingBlocks
{
    public static class ConsoleExtension
    {
        public static void WriteSeparator(string title)
        {
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
