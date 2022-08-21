using BuildingBlocks;

namespace PrototypeLibrary.ColorRegistryExample;

public static class ColorRegistryExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Color registry example");

        // Initialize registry with standard colors.
        var registry = new ColorRegistry
        {
            ["red"] = new Color(255, 0, 0),
            ["green"] = new Color(0, 255, 0),
            ["blue"] = new Color(0, 0, 255)
        };
        registry.List();

        // Clone red color and store it in the registry.
        var clonedColor = (registry["red"].Clone() as Color)!;
        clonedColor.Customize(clonedColor.Red, clonedColor.Green, 33);
        registry["custom"] = clonedColor;
        registry.List();

        // Clone custom color without storing it in the registry.
        _ = (registry["custom"].Clone() as Color)!;
        registry.List();
    }
}
