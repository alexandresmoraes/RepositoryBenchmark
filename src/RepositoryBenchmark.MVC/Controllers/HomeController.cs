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
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult EntityFramework()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    public ActionResult StoredProcedures()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}