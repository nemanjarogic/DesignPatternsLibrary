using System;
using System.Drawing;
using BuildingBlocks;

namespace FlyweightLibrary.ForestExample
{
    public static class ForestExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Forest example");

            var treeFactory = new TreeFactory();
            var forest = new Forest(treeFactory);

            forest.PlantTree("Oak", KnownColor.Brown, "Oak texture", 10.0, 12.0);
            forest.PlantTree("Oak", KnownColor.Brown, "Oak texture", 5.0, -77.4);
            forest.PlantTree("Maple", KnownColor.Brown, "Maple texture", 171.0, -28.7);
            forest.PlantTree("Birch", KnownColor.White, "Birch texture", 55.0, 15.0);
            forest.PlantTree("Willow", KnownColor.Brown, "Willow texture", -33.6, 12.2);
            forest.PlantTree("Oak", KnownColor.Brown, "Oak texture", 77.1, 18.8);

            Console.WriteLine();
            forest.Render();
        }
    }
}
