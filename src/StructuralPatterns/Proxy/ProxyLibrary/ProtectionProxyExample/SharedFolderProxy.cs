using System;

namespace ProxyLibrary.ProtectionProxyExample
{
    public class SharedFolderProxy : ISharedFolder
    {
        private readonly Employee _employee;
        private readonly SharedFolder _sharedFolder;

        public SharedFolderProxy(Employee employee, SharedFolder sharedFolder)
        {
            _employee = employee;
            _sharedFolder = sharedFolder;
        }

        public void Access()
        {
            if (_employee.Role == Role.Manager || _employee.Role == Role.CEO)
            {
                _sharedFolder.Access();
                return;
            }

            Console.WriteLine($"Employee with role: {_employee.Role} doesn't have access to the shared folder");
        }
    }
}
