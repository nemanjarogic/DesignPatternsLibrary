using System;
using BuildingBlocks;

namespace FlyweightLibrary.DotNetStringExample
{
    public static class DotNetStringExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator(".NET string example");

            string s1 = "flyweight";
            string s2 = "flyweight";
            string s3 = s1;

            Console.WriteLine("Enter s4: ");
            string s4 = Console.ReadLine();

            Console.WriteLine("Enter s5: ");
            string s5 = string.Intern(Console.ReadLine());

            // In this case, s1 and s2 are two separate strings, and hence the output should be false.
            // Surprisingly, the output is true! This is because .NET runtime in order to save space,
            // internally manages a string pool, and replaces this individual string with a shared instance.
            // OUTPUT: true
            Console.WriteLine($"\ns1 == s2 -> {ReferenceEquals(s1, s2)}");

            // If s3 refer to s1, then obviously the output of the program is expected to be true, which it is.
            // OUTPUT: true
            Console.WriteLine($"s1 == s3 -> {ReferenceEquals(s1, s3)}");

            // We can make use of Console.ReadLine to accept a string at runtime, and assign it to s4.
            // And a surprise, the output it false! By default .NET runtime doesn't replace runtime strings,
            // which are instances.
            // OUTPUT: false (if you enter 'flyweight')
            Console.WriteLine($"s1 == s4 -> {ReferenceEquals(s1, s4)}");

            // While .NET runtime by default doesn't replace runtime strings, which are instances, we can still
            // check if your string is present inside  the shared string pool by using string.Intern method.
            // Intern method is like the FlyweightFactory.
            // It returns a reference to an existing string if it is part of the pool.
            // OUTPUT: true (if you enter 'flyweight')
            Console.WriteLine($"s1 == s5 -> {ReferenceEquals(s1, s5)}");
        }
    }
}
