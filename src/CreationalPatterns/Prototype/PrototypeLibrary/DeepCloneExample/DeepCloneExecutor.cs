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
                    Name = "Project 1",
                    Description = "Simple project",
                }
            };

            var developerWithSameName = developer.Clone();
            developerWithSameName.Project.Name = "Project 2";
            developerWithSameName.Project.Description = "Complex project";

            developer.PrintDetails();
            developerWithSameName.PrintDetails();

        }
    }
}
