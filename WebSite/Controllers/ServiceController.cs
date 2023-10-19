using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = serviceManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult ServiceAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ServiceAdd(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ServiceEdit(int id)
        {
            var values = serviceManager.get(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult ServiceEdit(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
        public IActionResult ServiceDelete(int id)
        {
            var values = serviceManager.get(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
