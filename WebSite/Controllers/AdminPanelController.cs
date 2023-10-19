using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminSideBar()
        {
            return PartialView();
        }
        public PartialViewResult AdminHead()
        {
            return PartialView();
        }
        public PartialViewResult AdminScript()
        {
            return PartialView();
        }
    }
}
