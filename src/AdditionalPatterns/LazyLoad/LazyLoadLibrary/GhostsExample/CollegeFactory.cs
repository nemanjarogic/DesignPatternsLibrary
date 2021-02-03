namespace LazyLoadLibrary.GhostsExample
{
    public class CollegeFactory
    {
        public GhostCollege CreateFromId(int id)
        {
            return new GhostCollege(id);
        }
    }
}
