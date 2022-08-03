using BuildingBlocks;
using DecoratorLibrary.DataStorageExample.Components.Common;
using DecoratorLibrary.DataStorageExample.Decorators;
using File = DecoratorLibrary.DataStorageExample.Components.File;

namespace DecoratorLibrary.DataStorageExample;

public static class DataStorageExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Data storage example");

        ProcessFileWithPlainData();
        ProcessFileWithCompressedData();
        ProcessFileWithCompressedAndEncryptedData();
    }

    private static void ProcessFileWithPlainData()
    {
        IDataSource source = new File("file.dat");

        source.Write("Hello world");
        Console.WriteLine($"Read: {source.Read()}\n");
    }

    private static void ProcessFileWithCompressedData()
    {
        IDataSource source = new File("file.dat");
        source = new CompressionDecorator(source);

        source.Write("Hello world");
        Console.WriteLine($"Read: {source.Read()}\n");
    }

    private static void ProcessFileWithCompressedAndEncryptedData()
    {
        IDataSource source = new File("file.dat");
        source = new EncryptionDecorator(source);
        source = new CompressionDecorator(source);

        source.Write("Hello world");
        Console.WriteLine($"Read: {source.Read()}\n");
    }
}