using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
