namespace LazyLoadLibrary.ValueHolderExample
{
    public interface IValueLoader<T>
    {
        T Load();
    }
}
