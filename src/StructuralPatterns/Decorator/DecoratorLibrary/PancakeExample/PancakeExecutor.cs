using System;
using BuildingBlocks;
using DecoratorLibrary.PancakeExample.Components;
using DecoratorLibrary.PancakeExample.Components.Common;
using DecoratorLibrary.PancakeExample.Decorators;

namespace DecoratorLibrary.PancakeExample
{
    public static class PancakeExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Pancake example");

            Pancake pancake = new BigPancake();
            pancake = new WhippedCream(pancake);
            pancake = new MixedBerries(pancake);
            pancake = new MappleSyrup(pancake);

            Console.WriteLine(pancake.GetDescriptionAndAddIns());
            Console.WriteLine("{0:C2}", pancake.CalculatePrice());
        }
    }
}
