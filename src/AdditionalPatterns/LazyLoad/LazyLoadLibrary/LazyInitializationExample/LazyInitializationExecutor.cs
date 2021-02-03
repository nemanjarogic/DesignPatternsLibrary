using BuildingBlocks;

namespace LazyLoadLibrary.LazyInitializationExample
{
    public static class LazyInitializationExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Lazy initialization example");

            var college = new LazyCollege();
            college.ShowDetails();

            var dotNetCollege = new DotNetLazyCollege();
            dotNetCollege.ShowDetails();
        }
    }
}
