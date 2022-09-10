using BuildingBlocks;

namespace FluentInterfaceLibrary.BlobStorageExample;

public static class BlobStorageExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Blob Storage example");

        BlobStorageManager
            .Connect("DefaultEndpointsProtocol=https;AccountName=myAccountName;AccountKey=<account-key>")
            .OnBlob("container", "blob")
            .Download("blobStorageManual.pdf")
            .ToFolder(@"D:\DesignPatternsLibrary\Downloads");
    }
}