using BuildingBlocks;
using DecoratorLibrary.PancakeExample.Components;
using DecoratorLibrary.PancakeExample.Components.Common;
using DecoratorLibrary.PancakeExample.Decorators;

namespace DecoratorLibrary.PancakeExample;

public static class PancakeExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Pancake example");

        Pancake pancake = new BigPancake();
        pancake = new WhippedCream(pancake);
        pancake = new MixedBerries(pancake);
        pancake = new MapleSyrup(pancake);

        Console.WriteLine($"Order: {pancake.GetDescriptionAndAddIns()}");
        Console.WriteLine($"Price: {pancake.CalculatePrice():C2}");
    }
}
