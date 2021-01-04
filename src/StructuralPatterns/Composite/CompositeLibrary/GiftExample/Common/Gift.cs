namespace CompositeLibrary.GiftExample.Common
{
    public abstract class Gift
    {
        protected readonly string _description;
        protected readonly decimal _price;

        public Gift(string description, decimal price)
        {
            _description = description;
            _price = price;
        }

        public abstract decimal CalculatePrice();
    }
}
