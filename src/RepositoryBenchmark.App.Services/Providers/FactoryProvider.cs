using RepositoryBenchmark.Domain.Entities;
using System;
using System.Linq;

namespace RepositoryBenchmark.App.Services.Providers
{
  public static class FactoryProvider
  {
    private static readonly string _chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private static readonly Random _random = new Random();

    private static string RandomString(int size)
    {
      var result = new string(
          Enumerable.Repeat(_chars, size)
                    .Select(s => s[_random.Next(s.Length)])
                    .ToArray());
      return result;
    }
    private static int RandomInt32(int min, int max)
    {
      return _random.Next(min, max + 1);
    }
    private static decimal RandomNumberBetween(decimal min, decimal max)
    {
      var next = Convert.ToDecimal(_random.NextDouble());
      return min + (next * (max - min));
    }
    private static bool RandomBoolean()
    {
      return _random.Next(0, 100) > 50;
    }
    private static byte[] RandomByteArray(int size)
    {
      Byte[] b = new Byte[size];
      _random.NextBytes(b);
      return b;
    }

    public static TabelaPrimaria GetInstaceTabelaPrimaria()
    {
      return new TabelaPrimaria
      {
        Number = RandomInt32(1, 100),
        StringShort = RandomString(50),
        StringLarge = RandomString(255),
        Booleano = RandomBoolean(),
        Binario = RandomByteArray(1024),
        Data = DateTime.Now
      };
    }
  }
}