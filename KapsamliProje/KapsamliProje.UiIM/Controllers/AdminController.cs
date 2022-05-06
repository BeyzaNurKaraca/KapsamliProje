using Microsoft.AspNetCore.Mvc;

namespace KapsamliProje.UiIM.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Roles()
        {
            return View();
        }
    }
}
