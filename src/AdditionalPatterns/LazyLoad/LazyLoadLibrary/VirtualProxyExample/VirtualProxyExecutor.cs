using System;
using BuildingBlocks;

namespace LazyLoadLibrary.VirtualProxyExample
{
    public static class VirtualProxyExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Virtual proxy example");

            var collegeFactory = new CollegeFactory();
            var college = collegeFactory.CreateFromId(1);

            // College library shouldn't have been constructed before calling ShowDetails method.
            Console.WriteLine("Give me more details about the college!");
            college.ShowDetails();
        }
    }
}
