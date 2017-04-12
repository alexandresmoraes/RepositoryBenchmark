namespace RepositoryBenchmark.Domain.IUnitOfWork
{
  public interface IUnitOfWork
  {
    void BeginTransaction();
    void Commit();
    void Rollback();
    void Dispose();
  }
}