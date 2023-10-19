using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ErrorPages()
        {
            return View();
        }
    }
}
