namespace FluentInterfaceLibrary.BlobStorageExample.Contracts;

public interface IRead
{
    void FromFile(string filePath);
    void FromStream(Stream stream);
}