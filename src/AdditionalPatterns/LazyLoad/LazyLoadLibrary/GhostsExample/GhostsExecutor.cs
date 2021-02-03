using BuildingBlocks;

namespace LazyLoadLibrary.GhostsExample
{
    public static class GhostsExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Ghosts example");

            var collegeFactory = new CollegeFactory();
            var college = collegeFactory.CreateFromId(1);

            // College library shouldn't have been constructed before calling ShowDetails method.
            college.ShowDetails();
            college.ShowDetails();
        }
    }
}
