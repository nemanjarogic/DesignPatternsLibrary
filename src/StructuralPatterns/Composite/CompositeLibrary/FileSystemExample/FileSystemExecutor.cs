using System;
using BuildingBlocks;

namespace CompositeLibrary.FileSystemExample
{
    public static class FileSystemExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("File system example");

            var booksFolder = new Folder("Books");
            var cSharpFolder = new Folder("C#");
            var designPatternsFolder = new Folder("Design patterns");

            booksFolder.Add(cSharpFolder);
            booksFolder.Add(designPatternsFolder);

            cSharpFolder.Add(new File("C#_8.0_in_a_nutshell.pdf", 11.1));
            cSharpFolder.Add(new File("C#_in_depth.pdf", 4.9));

            designPatternsFolder.Add(new File("Head_first_design_patterns.pdf", 27.0));

            Console.WriteLine($"Total size of 'Books' folder: {booksFolder.GetSizeInMB()} MB");
            Console.WriteLine($"Total size of 'C#' folder: {cSharpFolder.GetSizeInMB()} MB");
            Console.WriteLine($"Total size of 'Design patterns' folder : {designPatternsFolder.GetSizeInMB()} MB");
        }
    }
}
