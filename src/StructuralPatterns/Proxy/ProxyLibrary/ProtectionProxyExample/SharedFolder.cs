using System;

namespace ProxyLibrary.ProtectionProxyExample
{
    public class SharedFolder : ISharedFolder
    {
        public void Access()
        {
            Console.WriteLine("Accessing to the shared folder...");
        }
    }
}
