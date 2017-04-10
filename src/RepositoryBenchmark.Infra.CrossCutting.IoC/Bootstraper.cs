using NHibernate;
using RepositoryBenchmark.App.Services.Services;
using SimpleInjector;

namespace RepositoryBenchmark.Infra.CrossCutting.IoC
{
  public class Bootstraper
  {
    public static void RegisterServices(Container container)
    {
      container.Register<ISessionFactory>(Data.NHibernate.Connection.SessionFactoryProvider.CreateInstance, Lifestyle.Singleton);
      container.Register<ISession>(() => container.GetInstance<ISessionFactory>().OpenSession(), Lifestyle.Scoped);
      container.Register<Data.NHibernate.Repositories.RepositoryTabelaPrimaria>(Lifestyle.Scoped);
      container.Register<Data.NHibernate.Repositories.RepositoryTabelaSecundaria>(Lifestyle.Scoped);
      container.Register<Data.NHibernate.Connection.UnitOfWork>(Lifestyle.Scoped);
      container.Register<ServiceNHibernate>(Lifestyle.Scoped);
    }
  }
}