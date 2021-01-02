using BuildingBlocks;
using PrototypeLibrary.DeepCloneExample.Models;

namespace PrototypeLibrary.DeepCloneExample
{
    public static class DeepCloneExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Deep clone example");

            var developer = new Developer
            {
                Name = "John Doe",
                Project = new Project
                {
                    Name = "File storage service",
                    Description = "Complex project",
                },
            };

            var clonedDeveloper = developer.Clone();
            clonedDeveloper.Project.Name = "Web crawler";

            developer.PrintDetails();
            clonedDeveloper.PrintDetails();
        }
    }
}
