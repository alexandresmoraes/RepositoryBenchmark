using RepositoryBenchmark.App.Services.Providers;
using RepositoryBenchmark.Domain.DTO;
using RepositoryBenchmark.Domain.Entities;
using RepositoryBenchmark.Domain.IRepositories;
using RepositoryBenchmark.Domain.IServices;
using RepositoryBenchmark.Domain.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RepositoryBenchmark.App.Services.Services
{
  public abstract class Service : IService
  {
    private readonly IRepository<TabelaPrimaria> _repositoryPrimario;
    private readonly IRepository<TabelaSecundaria> _repositorySecundario;
    private readonly IUnitOfWork _unitOfWork;

    public Service(
      IRepository<TabelaPrimaria> repositoryPrimario,
      IRepository<TabelaSecundaria> repositorySecundario,
      IUnitOfWork unitOfWork)
    {
      _repositoryPrimario = repositoryPrimario;
      _repositorySecundario = repositorySecundario;
      _unitOfWork = unitOfWork;
    }

    public void ExecuteCreateTest(ResultCreateDTO resultCreateDTO)
    {
      var sw = new Stopwatch();
      var swTotal = new Stopwatch();
      var bag = new List<TabelaPrimaria>();

      for (int i = 0; i < 500151; i++)
        bag.Add(FactoryProvider.GetInstaceTabelaPrimaria());

      swTotal.Start();

      #region 1a1000
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        for (int i = 0; i < 1000; i++)
          _repositoryPrimario.Create(bag[i]);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch (Exception e)
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      resultCreateDTO.Tempo1a1000 = sw.Elapsed;
      sw.Reset();
      #endregion 1a1000

      #region 1001a50000
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        for (int i = 1000; i < 50000; i++)
          _repositoryPrimario.Create(bag[i]);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      resultCreateDTO.Tempo1001a50000 = sw.Elapsed;
      sw.Reset();
      #endregion 1001a50000

      #region 50001a250000
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        for (int i = 50000; i < 250000; i++)
          _repositoryPrimario.Create(bag[i]);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      resultCreateDTO.Tempo50001a250000 = sw.Elapsed;
      sw.Reset();
      #endregion 50001a250000

      #region 250001a500000
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        for (int i = 250000; i < 500000; i++)
          _repositoryPrimario.Create(bag[i]);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      resultCreateDTO.Tempo250001a500000 = sw.Elapsed;
      sw.Reset();
      #endregion 250001a500000

      swTotal.Stop();
      resultCreateDTO.TempoTotal = swTotal.Elapsed;

      #region 1em500000
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        _repositoryPrimario.Create(bag[500000]);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      resultCreateDTO.Tempo1em500000 = sw.Elapsed;
      sw.Reset();
      #endregion 1em500000

      #region 50em500000
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        for (int i = 500001; i < 500051; i++)
          _repositoryPrimario.Create(bag[i]);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      resultCreateDTO.Tempo50em500000 = sw.Elapsed;
      sw.Reset();
      #endregion 50em500000

      #region 100em500000
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        for (int i = 500051; i < 500151; i++)
          _repositoryPrimario.Create(bag[i]);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      resultCreateDTO.Tempo100em500000 = sw.Elapsed;
      sw.Reset();
      #endregion 100em500000
    }
  }
}