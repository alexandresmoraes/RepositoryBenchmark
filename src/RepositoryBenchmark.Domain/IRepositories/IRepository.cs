using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryBenchmark.Domain.IRepositories
{
  public interface IRepository<T> : IDisposable
  {
    T Create(T entity);
    IEnumerable<T> Read(int maximoLinhas, int linhaInicial, params Expression<Func<T, object>>[] orderBys);
    T Update(T entity);
    void Delete(T entity);
  }
}