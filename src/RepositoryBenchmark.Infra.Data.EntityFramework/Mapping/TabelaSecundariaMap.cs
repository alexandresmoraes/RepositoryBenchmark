using RepositoryBenchmark.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace RepositoryBenchmark.Infra.Data.EntityFramework.Mapping
{
  public class TabelaSecundariaMap : EntityTypeConfiguration<TabelaSecundaria>
  {
    public TabelaSecundariaMap()
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

      HasRequired(t => t.TabelaPrimaria)
        .WithRequiredPrincipal(t => t.TabelaSecundaria);

      ToTable("tabela-secundaria");
    }
  }
}