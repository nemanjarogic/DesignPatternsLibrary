namespace LazyLoadLibrary.VirtualProxyExample;

public class CollegeFactory
{
    public College CreateFromId(int id) => new ProxyCollege(id);
}
