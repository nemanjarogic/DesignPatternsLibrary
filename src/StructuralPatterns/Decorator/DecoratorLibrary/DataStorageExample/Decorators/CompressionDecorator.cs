using DecoratorLibrary.DataStorageExample.Components.Common;
using DecoratorLibrary.DataStorageExample.Decorators.Common;

namespace DecoratorLibrary.DataStorageExample.Decorators;

/// <summary>
/// Concrete decorators must call methods on the wrapped object,
/// but may add something of their own to the result.
/// Decorators can execute the added behavior either before or after the call to a wrapped object.
/// </summary>
public class CompressionDecorator : DataSourceDecorator
{
    private readonly string _compressionBlock;

    public CompressionDecorator(IDataSource wrapee)
        : base(wrapee)
    {
        _compressionBlock = "--COMPRESSED--";
    }

    public override void Write(string data)
    {
        Console.WriteLine("Compression");

        var compressedData = Compress(data);
        _wrapee.Write(compressedData);
    }

    public override string Read()
    {
        var compressedData = _wrapee.Read();
        return Decompress(compressedData);
    }

    private string Compress(string data) =>
        $"{_compressionBlock}{data}{_compressionBlock}";

    private string Decompress(string data) =>
        data.Replace(_compressionBlock, string.Empty, StringComparison.InvariantCulture);
}
