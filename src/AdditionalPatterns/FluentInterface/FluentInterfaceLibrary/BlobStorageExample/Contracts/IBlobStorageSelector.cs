namespace FluentInterfaceLibrary.BlobStorageExample.Contracts;

public interface IBlobStorageSelector
{
    IBlobStorageAction OnBlob(string containerName, string blobName);
}