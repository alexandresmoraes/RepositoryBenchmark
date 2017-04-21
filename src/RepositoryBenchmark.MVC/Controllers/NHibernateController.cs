using RepositoryBenchmark.App.Services.Services;
using RepositoryBenchmark.Domain.Dto;
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

      var model = new ResultCreateDto();

      _serviceNHibernate.ExecuteCreateTest(model);

      return View(model);
    }
  }
}