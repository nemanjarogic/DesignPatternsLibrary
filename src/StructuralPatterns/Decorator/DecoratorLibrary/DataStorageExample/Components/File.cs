using System.Text;
using DecoratorLibrary.DataStorageExample.Components.Common;

namespace DecoratorLibrary.DataStorageExample.Components;

/// <summary>
/// Concrete components provide default implementations for the operations.
/// There might be several variations of these classes in a program.
/// </summary>
public class File : IDataSource
{
    private readonly string _name;
    private readonly StringBuilder _data;

    public File(string name)
    {
        _name = name;
        _data = new StringBuilder();
    }

    public void Write(string data)
    {
        _data.Append(data);

        Console.WriteLine($"Writing to the file: {_name}");
        Console.WriteLine($"Written: {data}");
    }

    public string Read() => _data.ToString();

    public void ClearContent() => _data.Clear();
}
