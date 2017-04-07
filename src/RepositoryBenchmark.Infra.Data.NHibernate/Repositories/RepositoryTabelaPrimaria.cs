using NHibernate;
using RepositoryBenchmark.Domain.Entities;
using RepositoryBenchmark.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryBenchmark.Infra.Data.NHibernate.Repositories
{
  public class RepositoryTabelaPrimaria : IRepository<TabelaPrimaria>, IDisposable
  {
    private readonly ISession _session;

    public RepositoryTabelaPrimaria(ISession session)
    {
      _session = session;
    }
    public TabelaPrimaria Create(TabelaPrimaria entity)
    {
      _session.SaveOrUpdate(entity);
      return entity;
    }
    public IEnumerable<TabelaPrimaria> Read(int maximoLinhas, int linhaInicial, params Expression<Func<TabelaPrimaria, object>>[] orderBys)
    {
      var query = _session.QueryOver<TabelaPrimaria>();

      if (orderBys != null)
        for (int i = 0; i < orderBys.Length; i++)
          if (i == 0)
            query.OrderBy(orderBys[i]);
          else
            query.ThenBy(orderBys[i]);

      return query.Skip(linhaInicial).Take(maximoLinhas).List();
    }
    public TabelaPrimaria Update(TabelaPrimaria entity)
    {
      _session.SaveOrUpdate(entity);
      return entity;
    }
    public void Delete(TabelaPrimaria entity)
    {
      _session.Delete(entity);
    }

    private bool disposed = false;
    protected virtual void Dispose(bool disposing)
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