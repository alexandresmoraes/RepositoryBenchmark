
namespace RepositoryBenchmark.App.Services.Services
{
  public class ServiceNHibernate : Service
  {
    public ServiceNHibernate(
      Infra.Data.NHibernate.Repositories.RepositoryTabelaPrimaria repositoryPrimario,
      Infra.Data.NHibernate.Repositories.RepositoryTabelaSecundaria repositorySecundario,
      Infra.Data.NHibernate.Connection.UnitOfWork unitOfWork)
      : base(repositoryPrimario, repositorySecundario, unitOfWork)
    {
    }
  }
}
