using RepositoryBenchmark.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace RepositoryBenchmark.Infra.Data.EntityFramework.Mapping
{
  public class TabelaPrimariaMap : EntityTypeConfiguration<TabelaPrimaria>
  {
    public TabelaPrimariaMap()
    {
      HasKey(t => t.Id);

      Property(t => t.Number)
        .IsRequired();

      Property(t => t.StringShort)
        .IsRequired()
        .HasMaxLength(50);

      Property(t => t.StringLarge)
        .IsRequired()
        .HasMaxLength(255);

      Property(t => t.Decimal)
        .IsRequired();

      Property(t => t.Booleano)
        .IsRequired();

      Property(t => t.Binario)
        .IsRequired();

      Property(t => t.Data)        
        .IsRequired();

      HasRequired(t => t.TabelaSecundaria)
        .WithRequiredPrincipal(t => t.TabelaPrimaria)
        .Map(m => m.MapKey("tabela-secundaria_id"));

      ToTable("tabela-primaria");
    }
  }
}
