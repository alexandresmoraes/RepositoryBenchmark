using RepositoryBenchmark.App.Services.Services;
using System.Threading.Tasks;
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
    public async Task<ActionResult> Index()
    {
      var model = await _serviceNHibernate.ExecuteCreateTest();

      return View(model);
    }
  }
}