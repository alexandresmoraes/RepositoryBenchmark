using System;

namespace RepositoryBenchmark.Domain.Entities
{
  public class TabelaPrimaria : IDisposable
  {
    public virtual int Id { get; set; }
    public virtual int Number { get; set; }
    public virtual string StringShort { get; set; }
    public virtual string StringLarge { get; set; }
    public virtual decimal Decimal { get; set; }
    public virtual bool Booleano { get; set; }
    public virtual byte[] Binario { get; set; }
    public virtual DateTime Data { get; set; }
    public virtual TabelaSecundaria TabelaSecundaria { get; set; }

    private bool disposed = false;
    protected void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          if (TabelaSecundaria != null)
            TabelaSecundaria.Dispose();
        }
      }
      this.disposed = true;
    }
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}