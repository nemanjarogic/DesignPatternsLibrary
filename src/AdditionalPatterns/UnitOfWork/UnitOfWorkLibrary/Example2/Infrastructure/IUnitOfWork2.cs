﻿namespace UnitOfWorkLibrary.Example2.Infrastructure;

public interface IUnitOfWork2 : IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    Task<bool> SaveChangesAndDispatchDomainEventsAsync(CancellationToken cancellationToken = default);
}
