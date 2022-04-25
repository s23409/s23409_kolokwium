using Microsoft.AspNetCore.Mvc;

namespace s23409_kolokwium.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
