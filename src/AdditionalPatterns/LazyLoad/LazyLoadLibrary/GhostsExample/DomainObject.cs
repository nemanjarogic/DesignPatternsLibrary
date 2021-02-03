namespace LazyLoadLibrary.GhostsExample
{
    public abstract class DomainObject
    {
        private LoadStatus _status;

        public DomainObject(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public bool IsGhost => _status == LoadStatus.Unloaded;

        public bool IsLoaded => _status == LoadStatus.Loaded;

        /// <summary>
        /// Note template method pattern.
        /// </summary>
        public virtual void LoadIfNecessary()
        {
            if (!IsGhost)
            {
                return;
            }

            var dataRow = FetchData();

            MarkAsLoading();
            ApplyLoadedData(dataRow);
            MarkAsLoaded();
        }

        protected abstract object[] FetchData();

        protected abstract void ApplyLoadedData(object[] dataRow);

        private void MarkAsLoading() => _status = LoadStatus.Loading;

        private void MarkAsLoaded() => _status = LoadStatus.Loaded;
    }
}
