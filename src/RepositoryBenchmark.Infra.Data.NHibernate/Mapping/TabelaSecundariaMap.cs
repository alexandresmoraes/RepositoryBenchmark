using FluentNHibernate.Mapping;
using RepositoryBenchmark.Domain.Entities;

namespace RepositoryBenchmark.Infra.Data.NHibernate.Mapping
{
  public class TabelaSecundariaMap : ClassMap<TabelaSecundaria>
  {
    public TabelaSecundariaMap()
    {
      Table("tabela-secundaria");

      Map(t => t.Number)
        .Not.Nullable();

      Map(t => t.StringShort)
        .Not.Nullable()
        .Length(50);

      Map(t => t.StringLarge)
        .Not.Nullable()
        .Length(50);

      Map(t => t.Decimal)
        .Not.Nullable();

      Map(t => t.Booleano)
        .Not.Nullable();

      Map(t => t.Binario)
       .Not.Nullable();

      Map(t => t.Data)
        .Not.Nullable();

      References(t => t.TabelaPrimaria)
        .Not.Nullable();
    }
  }
}
