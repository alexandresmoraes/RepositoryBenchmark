using System;
using System.Collections.Generic;
using RepositoryBenchmark.Domain.Entities;
using RepositoryBenchmark.Domain.IRepositories;

namespace RepositoryBenchmark.Infra.Data.EntityFramework.Repositories
{
  public class RepositoryTabelaPrimaria : IRepository<TabelaPrimaria>, IDisposable
  {
    public TabelaPrimaria Create(TabelaPrimaria entity)
    {
      throw new NotImplementedException();
    }

    public bool Delete(TabelaPrimaria entity)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<TabelaPrimaria> Read(int maximoLinhas, int linhaInicial)
    {
      throw new NotImplementedException();
    }

    public TabelaPrimaria Update(TabelaPrimaria entity)
    {
      throw new NotImplementedException();
    }
  }
}
