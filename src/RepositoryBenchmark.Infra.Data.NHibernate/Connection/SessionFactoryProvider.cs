using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using RepositoryBenchmark.Infra.Data.NHibernate.Mapping;
using System;
using System.IO;

namespace RepositoryBenchmark.Infra.Data.NHibernate.Connection
{
  public static class SessionFactoryProvider
  {
    private static void TreatConfiguration(Configuration configuration)
    {
      var update = new SchemaUpdate(configuration);
      update.Execute(LogSql, true);
    }

    private static void LogSql(string sql)
    {
      using (var file = new FileStream(@"D:\update.sql", FileMode.Append))
      {
        using (var sw = new StreamWriter(file))
        {
          sw.Write(sql);
        }
      }
    }

    public static ISessionFactory CreateInstance()
    {
      try
      {
        var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        return Fluently
          .Configure()
          .Database(PostgreSQLConfiguration.PostgreSQL82.ConnectionString(connectionString))
          .Mappings(m => m.FluentMappings.Add<TabelaPrimariaMap>())
          .Mappings(m => m.FluentMappings.Add<TabelaSecundariaMap>())
          .ExposeConfiguration(TreatConfiguration)
          .BuildConfiguration()
          .BuildSessionFactory();
      }
      catch (Exception ex)
      {
        throw new Exception("Falhou a conexão: " + ex.Message, ex);
      }
    }
  }
}
