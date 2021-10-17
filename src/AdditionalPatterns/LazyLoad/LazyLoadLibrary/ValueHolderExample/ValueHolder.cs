namespace LazyLoadLibrary.ValueHolderExample
{
    /// <summary>
    /// A value holder is a generic object that handles the lazy loading behavior
    /// and appears in place of the object’s data fields.
    /// When clients need to access it, they simply ask the value holder for its value.
    /// That is the moment when the value gets loaded (from a database or similar source).
    /// </summary>
    /// <typeparam name="T">Value type.</typeparam>
    public class ValueHolder<T>
    {
        private readonly IValueLoader<T> _loader;
        private T _value;

        public ValueHolder(IValueLoader<T> loader)
        {
            _loader = loader;
        }

        public T Value
        {
            get
            {
                if (_value == null)
                {
                    _value = _loader.Load();
                }

                return _value;
            }
        }
    }
}
