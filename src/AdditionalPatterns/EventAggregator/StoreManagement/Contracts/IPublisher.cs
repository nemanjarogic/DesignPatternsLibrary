namespace StoreManagement.Contracts;

public interface IPublisher
{
    void Publish(string payload);
}