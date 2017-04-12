using System;
using RepositoryBenchmark.Domain.IUnitOfWork;
using NHibernate;

namespace RepositoryBenchmark.Infra.Data.NHibernate.Connection
{
  public class UnitOfWork : IUnitOfWork, IDisposable
  {
    private readonly ISessionFactory _sessionFactory;
    private ISession _session;
    private ITransaction _transaction;

    public UnitOfWork(ISessionFactory sessionFactory)
    {
      _sessionFactory = sessionFactory;
    }
    public void BeginTransaction()
    {
      _session = _sessionFactory.OpenSession();
      _transaction = _session.BeginTransaction();
    }
    public void Commit()
    {
      if (_transaction != null && _transaction.IsActive)
      {
        _transaction.Commit();
        _session.Dispose();
      }
    }
    public void Rollback()
    {
      if (_transaction != null && _transaction.IsActive)
      {
        _transaction.Rollback();
        _session.Dispose();
      }
    }

    private bool disposed = false;
    protected void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          if (_session != null)
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