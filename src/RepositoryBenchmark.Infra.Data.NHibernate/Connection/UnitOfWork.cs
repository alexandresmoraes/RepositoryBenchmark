using System;
using RepositoryBenchmark.Domain.IUnitOfWork;
using NHibernate;

namespace RepositoryBenchmark.Infra.Data.NHibernate.Connection
{
  public class UnitOfWork : IUnitOfWork, IDisposable
  {
    private readonly ISession _session;
    private ITransaction _transaction;

    public UnitOfWork(ISession session)
    {
      _session = session;
    }
    public void BeginTransaction()
    {
      _transaction = _session.BeginTransaction();
    }
    public void Commit()
    {
      if (_transaction != null && _transaction.IsActive)
        _transaction.Commit();
    }
    public void Rollback()
    {
      if (_transaction != null && _transaction.IsActive)
        _transaction.Rollback();
    }

    private bool disposed = false;
    protected void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          _session.Dispose();
        }
      }
      this.disposed = true;
    }
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}