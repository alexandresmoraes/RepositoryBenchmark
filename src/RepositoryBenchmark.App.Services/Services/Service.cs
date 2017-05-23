using RepositoryBenchmark.App.Services.Providers;
using RepositoryBenchmark.Domain.Dto;
using RepositoryBenchmark.Domain.Entities;
using RepositoryBenchmark.Domain.IRepositories;
using RepositoryBenchmark.Domain.IServices;
using RepositoryBenchmark.Domain.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryBenchmark.App.Services.Services
{
  public abstract class Service : IService, IDisposable
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

    public Task<ResultCreateDto> ExecuteCreateTest()
    {
      var sw = new Stopwatch();
      var resultCreateDTO = new ResultCreateDto();

      #region 0010
      List<TabelaPrimaria> list = FactoryProvider
        .GetListTabelaPrimaria(10*50)
        .ToList();
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        foreach (var item in list)
          _repositoryPrimario.Create(item);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch (Exception)
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      finally
      {
        list.ForEach(i => i.Dispose());
        list = null;
      }

      resultCreateDTO._01_0010_X50 = sw.Elapsed;
      sw.Reset();
      #endregion 0010

      #region 0050
      list = FactoryProvider
        .GetListTabelaPrimaria(50 * 50)
        .ToList();

      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        foreach (var item in list)
          _repositoryPrimario.Create(item);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch (Exception)
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      finally
      {
        list.ForEach(i => i.Dispose());
        list = null;
      }

      resultCreateDTO._02_0050_X50 = sw.Elapsed;
      sw.Reset();
      #endregion 0050

      #region 0100
      list = FactoryProvider.GetListTabelaPrimaria(100 * 50).ToList();
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        foreach (var item in list)
          _repositoryPrimario.Create(item);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch (Exception)
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      finally
      {
        list.ForEach(i => i.Dispose());
        list = null;
      }

      resultCreateDTO._03_0100_X50 = sw.Elapsed;
      sw.Reset();
      #endregion 0100

      #region 0500
      list = FactoryProvider.GetListTabelaPrimaria(500 * 50).ToList();
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        foreach (var item in list)
          _repositoryPrimario.Create(item);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch (Exception)
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      finally
      {
        list.ForEach(i => i.Dispose());
        list = null;
      }

      resultCreateDTO._04_0500_X50 = sw.Elapsed;
      sw.Reset();
      #endregion 0500

      #region 1000
      list = FactoryProvider.GetListTabelaPrimaria(1000 * 50).ToList();
      try
      {
        sw.Start();
        _unitOfWork.BeginTransaction();

        foreach (var item in list)
          _repositoryPrimario.Create(item);

        _unitOfWork.Commit();
        sw.Stop();
      }
      catch (Exception)
      {
        _unitOfWork.Rollback();
        sw.Stop();
      }
      finally
      {
        list.ForEach(i => i.Dispose());
        list = null;
      }

      resultCreateDTO._05_1000_X50 = sw.Elapsed;
      sw.Reset();
      #endregion 1000

      return Task.FromResult(resultCreateDTO);
    }

    private bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          _repositoryPrimario.Dispose();
          _repositorySecundario.Dispose();
          _unitOfWork.Dispose();
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