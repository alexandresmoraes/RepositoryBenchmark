using RepositoryBenchmark.Domain.Dto;
using System.Threading.Tasks;

namespace RepositoryBenchmark.Domain.IServices
{
  public interface IService
  {
    Task<ResultCreateDto> ExecuteCreateTest();
  }
}