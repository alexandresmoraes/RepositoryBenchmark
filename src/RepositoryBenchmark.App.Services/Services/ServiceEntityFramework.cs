using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryBenchmark.App.Services.Services
{
  public class ServiceEntityFramework
  {
    public ServiceEntityFramework(
      Infra.Data.EntityFramework.Repositories.RepositoryTabelaPrimaria repositoryPrimario,
      Infra.Data.EntityFramework.Repositories.RepositoryTabelaSecundaria repositorySecundario,
      Infra.Data.NHibernate.Connection.UnitOfWork unitOfWork)
    {
    }
  }
}
