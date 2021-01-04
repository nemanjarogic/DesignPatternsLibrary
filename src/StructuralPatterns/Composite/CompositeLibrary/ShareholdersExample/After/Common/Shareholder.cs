namespace CompositeLibrary.ShareholdersExample.After.Common
{
    public abstract class Shareholder
    {
        public string Name { get; set; }

        public virtual int NumberOfShares { get; set; }

        public abstract void PrintReport();
    }
}
