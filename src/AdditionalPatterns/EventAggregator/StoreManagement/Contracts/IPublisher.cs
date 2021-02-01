namespace EventAggregatorLibrary.Contracts
{
    public interface IPublisher
    {
        void Publish(string payload);
    }
}
