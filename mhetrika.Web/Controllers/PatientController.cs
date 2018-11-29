using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }
    }
}