using PrototypeLibrary.ColorRegistryExample.Common;

namespace PrototypeLibrary.ColorRegistryExample;

public class ColorRegistry
{
    private readonly Dictionary<string, IColorPrototype> _colors = new();

    public IColorPrototype this[string key]
    {
        get => _colors[key];
        set => _colors[key] = value;
    }

    public void List()
    {
        Console.WriteLine("Available colors in the registry...");

        foreach (var color in _colors)
        {
            Console.WriteLine($"Name: {color.Key}");
        }
    }
}
