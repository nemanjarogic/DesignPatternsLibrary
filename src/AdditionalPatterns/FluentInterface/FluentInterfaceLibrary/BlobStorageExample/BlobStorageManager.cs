using FluentInterfaceLibrary.BlobStorageExample.Contracts;

namespace FluentInterfaceLibrary.BlobStorageExample;

public sealed class BlobStorageManager : IBlobStorageSelector, IBlobStorageAction, IRead, IWrite
{
    private readonly string _connectionString;
    private string _containerName;
    private string _blobName;

    private BlobStorageManager(string connectionString)
    {
        _connectionString = connectionString;
        _containerName = string.Empty;
        _blobName = string.Empty;
    }

    #region Blob storage connection

    public static IBlobStorageSelector Connect(string connectionString)
    {
        Console.WriteLine($"Connecting to the storage account using the connection string: {connectionString}");
        var connection = new BlobStorageManager(connectionString);
        Console.WriteLine("Connection with the storage account is successfully established.");

        return connection;
    }

    public IBlobStorageAction OnBlob(string containerName, string blobName)
    {
        _containerName = containerName;
        _blobName = blobName;

        Console.WriteLine($"The blob storage /{containerName}/{blobName} is ready for incoming requests.");
        return this;
    }

    #endregion Blob storage connection

    #region Download

    public IWrite Download(string fileName)
    {
        Console.WriteLine($"The file {fileName} will be download from the /{_containerName}/{_blobName}");
        return this;
    }

    public void ToFolder(string folderPath) =>
        Console.WriteLine($"The file is downloaded from the /{_containerName}/{_blobName} to the directory {folderPath}.");

    #endregion Download

    #region Upload

    public IRead Upload(string fileName)
    {
        Console.WriteLine($"The file {fileName} will be uploaded to the /{_containerName}/{_blobName}");
        return this;
    }

    public void FromFile(string filePath) =>
        Console.WriteLine($"The file is uploaded from the user's machine to the /{_containerName}/{_blobName}.");

    public void FromStream(Stream stream) =>
        Console.WriteLine($"The file is uploaded from the stream to the /{_containerName}/{_blobName}.");

    #endregion Upload

    #region Preview

    public void Preview(string fileName)
    {
        Console.WriteLine($"Previewing the file {fileName} from the /{_containerName}/{_blobName}...");
    }

    #endregion Preview
}