using System;

namespace RepositoryBenchmark.Domain.Entities
{
  public class TabelaSecundaria
  {
    public virtual int Id { get; set; }
    public virtual int Number { get; set; }
    public virtual string StringShort { get; set; }
    public virtual string StringLarge { get; set; }
    public virtual decimal Decimal { get; set; }
    public virtual bool Booleano { get; set; }
    public virtual byte[] Binario { get; set; }
    public virtual DateTime Data { get; set; }
  }
}