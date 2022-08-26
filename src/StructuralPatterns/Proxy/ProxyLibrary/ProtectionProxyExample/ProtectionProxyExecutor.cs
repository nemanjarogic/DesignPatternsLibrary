using BuildingBlocks;

namespace ProxyLibrary.ProtectionProxyExample;

public static class ProtectionProxyExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Protection proxy example");

        TryToAccessTheSharedFolder("johndoe", "password", Role.Worker);
        TryToAccessTheSharedFolder("elonmusk", "password", Role.CEO);
    }

    private static void TryToAccessTheSharedFolder(string username, string password, Role role)
    {
        Console.WriteLine(
            $"\nThe employee with the username '{username}' and the role '{role}' " +
            $"is trying to access the shared folder...");

        var employee = new Employee(username, password, role);
        var sharedFolder = new SharedFolder();
        var folderProxy = new SharedFolderProxy(employee, sharedFolder);

        folderProxy.Access();
    }
}
