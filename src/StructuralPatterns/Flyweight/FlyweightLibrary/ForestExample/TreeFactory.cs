using System.Drawing;

namespace FlyweightLibrary.ForestExample;

/// <summary>
/// Flyweight factory decides whether to re-use existing flyweight or to create a new object.
/// </summary>
public class TreeFactory
{
    private readonly Dictionary<string, TreeType> _treeTypes;

    public TreeFactory()
    {
        _treeTypes = new Dictionary<string, TreeType>();
    }

    public TreeType GetTreeType(string name, KnownColor color, string texture)
    {
        var key = GetTreeTypeKey(name, color, texture);

        if (_treeTypes.TryGetValue(key, out var treeType))
        {
            Console.WriteLine($"Returning already initialized {name} tree with {color} color and {texture} from the tree factory...");
            return treeType;
        }

        treeType = new TreeType(name, color, texture);
        _treeTypes.Add(key, treeType);
        Console.WriteLine($"Registered new type: {name} tree with {color} color and {texture}");

        return treeType;
    }

    private static string GetTreeTypeKey(string name, KnownColor color, string texture) => $"{name}-{color}-{texture}";
}
