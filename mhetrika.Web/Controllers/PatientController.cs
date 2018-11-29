using AutoMapper;
using mhetrika.core.Entities;
using Mhetrika.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class PatientController : Controller
    {
        private readonly IMapper _mapper;

        public PatientController(IMapper mapper)
        {
            mapper = _mapper;
        }

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
            var p = Mapper.Map<Patient>(patientViewModel);


            return View();
        }
    }
}