using RepositoryBenchmark.Domain.DTO;
using RepositoryBenchmark.Domain.Entities;
using RepositoryBenchmark.Domain.IRepositories;
using RepositoryBenchmark.Domain.IServices;

namespace RepositoryBenchmark.App.Services.Services
{
  public class ServiceNHibernate : IServiceNHibernate
  {
    private readonly IRepository<TabelaPrimaria> _repositoryPrimario;

    public ServiceNHibernate(IRepository<TabelaPrimaria> repositoryPrimario)
    {
      _repositoryPrimario = repositoryPrimario;
    }

    public ResultCreateDTO ExecuteCreateTest()
    {
      return null;
    }
  }
}