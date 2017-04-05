using System.Collections.Generic;

namespace RepositoryBenchmark.Domain.IRepositories
{
  public interface IRepository<T>
  {
    T Create(T entity);
    IEnumerable<T> Read(int maximoLinhas, int linhaInicial);
    T Update(T entity);
    bool Delete(T entity);
  }
}