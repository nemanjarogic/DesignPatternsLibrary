using System;
using BuildingBlocks;

namespace ProxyLibrary.ProtectionProxyExample
{
    public static class ProtectionProxyExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Protection proxy example");

            TryToAccessToTheSharedFolder("johndoe", "password", Role.Worker);
            TryToAccessToTheSharedFolder("elonmusk", "password", Role.CEO);
        }

        private static void TryToAccessToTheSharedFolder(string username, string password, Role role)
        {
            Console.WriteLine(
                $"\nEmployee with username: {username} and role {role} " +
                $"is trying to access to the shared folder...");

            var employee = new Employee(username, password, role);
            var sharedFolder = new SharedFolder();
            var folderProxy = new SharedFolderProxy(employee, sharedFolder);

            folderProxy.Access();
        }
    }
}
