namespace LazyLoadLibrary.ValueHolderExample;

public interface IValueLoader<out T>
{
    T Load();
}
