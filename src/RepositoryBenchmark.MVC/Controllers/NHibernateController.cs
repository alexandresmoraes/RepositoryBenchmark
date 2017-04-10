using RepositoryBenchmark.App.Services.Services;
using RepositoryBenchmark.Domain.DTO;
using System.Web.Mvc;

namespace RepositoryBenchmark.MVC.Controllers
{
  public class NHibernateController : Controller
  {
    private readonly ServiceNHibernate _serviceNHibernate;

    public NHibernateController(ServiceNHibernate serviceNHibernate)
    {
      _serviceNHibernate = serviceNHibernate;
    }

    // GET: NHibernate
    public ActionResult Index()
    {

      var result = new ResultCreateDTO();
      _serviceNHibernate.ExecuteCreateTest(result);

      return View();
    }
  }
}