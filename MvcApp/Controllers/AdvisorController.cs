using Microsoft.AspNetCore.Mvc;
using MvcApp.Models.Entities;
using MvcApp.Models.Repositories.Abstracts;

namespace MvcApp.Controllers
{
    public class AdvisorController : Controller
    {
        private readonly IAdvisorRepository _advisorRepository;
        public AdvisorController(IAdvisorRepository advisorRepository)
        {
            _advisorRepository = advisorRepository;
        }
        public IActionResult Add(Advisor advisor)
        {
            _advisorRepository.Add(advisor);
            return View();
        }
        public IActionResult Delete(Advisor advisor)
        {
            _advisorRepository.Delete(advisor);
            return View();
        }
        public IActionResult Update(Advisor advisor)
        {
            _advisorRepository.Update(advisor);
            return View();
        }
        public IActionResult Get(string id)
        {
            _advisorRepository.Get(id);
            return View();
        }
    }
}
