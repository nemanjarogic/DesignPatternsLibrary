using System;
using BuildingBlocks;

namespace LazyLoadLibrary.LazyInitializationExample
{
    public static class LazyInitializationExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Lazy initialization example");

            var college = new LazyCollege();
            Console.WriteLine("Give me more details about the college!");
            college.ShowDetails();

            var dotNetCollege = new DotNetLazyCollege();
            Console.WriteLine("\nGive me more details about the college!");
            dotNetCollege.ShowDetails();
        }
    }
}
