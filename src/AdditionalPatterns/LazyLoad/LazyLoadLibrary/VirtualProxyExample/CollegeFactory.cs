namespace LazyLoadLibrary.VirtualProxyExample
{
    public class CollegeFactory
    {
        public College CreateFromId(int id)
        {
            return new ProxyCollege(id);
        }
    }
}
