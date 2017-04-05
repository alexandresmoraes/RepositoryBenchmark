using RepositoryBenchmark.Domain.Entities;
using RepositoryBenchmark.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryBenchmark.Infra.Data.NHibernate.Repositories
{
  public class RepositoryTabelaSecundaria : IRepository<TabelaSecundaria>, IDisposable
  {
    public TabelaSecundaria Create(TabelaSecundaria entity)
    {
      throw new NotImplementedException();
    }

    public bool Delete(TabelaSecundaria entity)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<TabelaSecundaria> Read(int maximoLinhas, int linhaInicial)
    {
      throw new NotImplementedException();
    }

    public TabelaSecundaria Update(TabelaSecundaria entity)
    {
      throw new NotImplementedException();
    }
  }
}
