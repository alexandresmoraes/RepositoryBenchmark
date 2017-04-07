using System.Web.Mvc;

namespace RepositoryBenchmark.MVC.Controllers
{
  public class NHibernateController : Controller
  {
    // GET: NHibernate
    public ActionResult Index()
    {
      return View();
    }
  }
}