using RepositoryBenchmark.Domain.Entities;
using RepositoryBenchmark.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryBenchmark.Infra.Data.NHibernate.Repositories
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
