using Microsoft.AspNetCore.Mvc;

namespace TableauDemoAppDotnet.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
