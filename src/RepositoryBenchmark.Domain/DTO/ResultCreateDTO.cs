using System;

namespace RepositoryBenchmark.Domain.DTO
{
  public class ResultCreateDTO
  {
    public TimeSpan Tempo1a1000 { get; set; }
    public TimeSpan Tempo1001a50000 { get; set; }
    public TimeSpan Tempo50001a250000 { get; set; }
    public TimeSpan Tempo250001a500000 { get; set; }
    public TimeSpan TempoTotal { get; set; }
    public TimeSpan Tempo1em500000 { get; set; }
    public TimeSpan Tempo50em500000 { get; set; }
    public TimeSpan Tempo100em500000 { get; set; }
  }
}