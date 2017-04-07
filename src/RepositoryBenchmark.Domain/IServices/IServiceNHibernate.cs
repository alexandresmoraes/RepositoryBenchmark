using RepositoryBenchmark.Domain.DTO;

namespace RepositoryBenchmark.Domain.IServices
{
  public interface IServiceNHibernate
  {
    ResultCreateDTO ExecuteCreateTest();
  }
}