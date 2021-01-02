using BuildingBlocks;

namespace PrototypeLibrary.ColorRegistryExample
{
    public static class ColorRegistryExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Color registry example");

            var registry = new ColorRegistry();

            // Initialize registry with standard colors
            registry["red"] = new Color(255, 0, 0);
            registry["green"] = new Color(0, 255, 0);
            registry["blue"] = new Color(0, 0, 255);

            // Clone red color
            var clonedColor = registry["red"].Clone() as Color;

            clonedColor.Customize(clonedColor.Red, clonedColor.Green, 33);
            registry["custom"] = clonedColor;

            // Clone custom color
            var secondClonedColor = registry["custom"].Clone() as Color;
        }
    }
}
