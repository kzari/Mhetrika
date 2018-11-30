using AutoMapper;
using mhetrika.core.Entities;
using Mhetrika.Web.ViewModels;
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

        [HttpPost]
        public ActionResult New(PatientViewModel patientViewModel)
        {
            var patient = Mapper.Map<Patient>(patientViewModel);

            return View();
        }
    }
}