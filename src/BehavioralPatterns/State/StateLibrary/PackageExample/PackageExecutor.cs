using BuildingBlocks;

namespace StateLibrary.PackageExample
{
    public static class PackageExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Package example");

            Package package = new Package();
            package.PrintStatus();

            package.Proceed();
            package.PrintStatus();

            package.Proceed();
            package.PrintStatus();

            package.Proceed();
            package.PrintStatus();
        }
    }
}
