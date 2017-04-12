using System;

namespace RepositoryBenchmark.Domain.Entities
{
  public class TabelaSecundaria : IDisposable
  {
    public virtual int Id { get; set; }
    public virtual int Number { get; set; }
    public virtual string StringShort { get; set; }
    public virtual string StringLarge { get; set; }
    public virtual decimal Decimal { get; set; }
    public virtual bool Booleano { get; set; }
    public virtual byte[] Binario { get; set; }
    public virtual DateTime Data { get; set; }

    private bool disposed = false;
    protected void Dispose(bool disposing)
    {
      this.disposed = true;
    }
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}