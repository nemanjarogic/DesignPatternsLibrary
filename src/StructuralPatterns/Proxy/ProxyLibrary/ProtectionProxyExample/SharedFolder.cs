namespace ProxyLibrary.ProtectionProxyExample;

public class SharedFolder : ISharedFolder
{
    public void Access() => Console.WriteLine("The shared folder is opened.");
}
