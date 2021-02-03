namespace LazyLoadLibrary.ValueHolderExample
{
    public class CollegeFactory
    {
        public ValueHolderCollege CreateFromId(int id)
        {
            return new ValueHolderCollege(id);
        }
    }
}
