using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
