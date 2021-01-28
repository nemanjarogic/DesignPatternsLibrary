using System;
using BuildingBlocks;

namespace TemplateMethodLibrary.BreadExample
{
    public static class BreadExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Bread example");

            var whiteBread = new WhiteBread();
            whiteBread.Make();

            Console.WriteLine();

            var wholeWheatBread = new WholeWheatBread();
            wholeWheatBread.Make();
        }
    }
}
