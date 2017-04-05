using RepositoryBenchmark.Domain.Entities;
using RepositoryBenchmark.Infra.Data.EntityFramework.Mapping;
using System.Data.Entity;

namespace RepositoryBenchmark.Infra.Data.EntityFramework.Connection
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext() : base("DefaultConnection")
    {
      Configuration.LazyLoadingEnabled = false;
    }

    public DbSet<TabelaPrimaria> TabelaPrimaria { get; set; }
    public DbSet<TabelaSecundaria> TabelaSecundaria { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add(new TabelaPrimariaMap());
      modelBuilder.Configurations.Add(new TabelaSecundariaMap());      

      base.OnModelCreating(modelBuilder);
    }
  }
}
