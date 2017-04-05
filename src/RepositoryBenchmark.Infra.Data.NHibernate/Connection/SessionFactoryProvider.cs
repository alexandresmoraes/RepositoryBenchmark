using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using RepositoryBenchmark.Infra.Data.NHibernate.Mapping;
using System;

namespace RepositoryBenchmark.Infra.Data.NHibernate.Connection
{
  public class SessionFactoryProvider
  {
    private static readonly IPersistenceConfigurer SqlServer2008Configuration =
        MsSqlConfiguration.MsSql2012.ConnectionString(
            c => c.FromConnectionStringWithKey("ConnectionString"));
    public ISessionFactory CreateInstance()
    {
      try
      {        
        var config = Fluently.Configure().Database(SqlServer2008Configuration)
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TabelaPrimariaMap>())
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TabelaSecundariaMap>());
        return config.BuildConfiguration().BuildSessionFactory();
      }
      catch (Exception ex)
      {
        throw new Exception("Failed/Denied of Access/Database does not exist: " + ex.Message, ex);
      }
    }
  }
}
