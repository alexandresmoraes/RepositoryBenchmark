using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryBenchmark.MVC.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult NHibernate()
    {
      ViewBag.Message = "NHibernate Benchmark.";

      return View();
    }

    public ActionResult EntityFramework()
    {
      ViewBag.Message = "Entity Framework Benchmark.";

      return View();
    }

    public ActionResult StoredProcedures()
    {
      ViewBag.Message = "Store Procedured Dapper Benchmark.";

      return View();
    }
  }
}