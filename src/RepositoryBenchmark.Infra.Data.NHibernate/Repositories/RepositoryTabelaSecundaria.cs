using NHibernate;
using RepositoryBenchmark.Domain.Entities;
using RepositoryBenchmark.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryBenchmark.Infra.Data.NHibernate.Repositories
{
  public class RepositoryTabelaSecundaria : IRepository<TabelaSecundaria>, IDisposable
  {
    private readonly ISession _session;

    public RepositoryTabelaSecundaria(ISession session)
    {
      _session = session;
    }
    public TabelaSecundaria Create(TabelaSecundaria entity)
    {
      _session.SaveOrUpdate(entity);
      return entity;
    }
    public IEnumerable<TabelaSecundaria> Read(int maximoLinhas, int linhaInicial, params Expression<Func<TabelaSecundaria, object>>[] orderBys)
    {
      var query = _session.QueryOver<TabelaSecundaria>();

      if (orderBys != null)
        for (int i = 0; i < orderBys.Length; i++)
          if (i == 0)
            query.OrderBy(orderBys[i]);
          else
            query.ThenBy(orderBys[i]);

      return query.Skip(linhaInicial).Take(maximoLinhas).List();
    }
    public TabelaSecundaria Update(TabelaSecundaria entity)
    {
      _session.SaveOrUpdate(entity);
      return entity;
    }
    public void Delete(TabelaSecundaria entity)
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
