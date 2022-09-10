namespace FluentInterfaceLibrary.BlobStorageExample.Contracts;

// Interfaces IWrite and IRead are used as a prevention mechanism for invalid method combinations.
public interface IBlobStorageAction
{
    IWrite Download(string fileName);
    IRead Upload(string fileName);
    void Preview(string fileName);
}