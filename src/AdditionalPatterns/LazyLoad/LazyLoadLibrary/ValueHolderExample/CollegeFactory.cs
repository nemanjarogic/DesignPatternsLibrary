namespace LazyLoadLibrary.ValueHolderExample;

public class CollegeFactory
{
    public ValueHolderCollege CreateFromId(int id) => new(id);
}
