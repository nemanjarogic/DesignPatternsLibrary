namespace OrderManagement.Infrastructure.Repositories.Contracts
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
