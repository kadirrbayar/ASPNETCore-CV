using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebSite.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager userManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult ListUser()
        {
            var result = userManager.GetAll();
            var values = JsonConvert.SerializeObject(result);
            return Json(values);
        }

        [HttpPost]
        public IActionResult DeleteUser(int id)
        {
            var result = userManager.get(id);
            userManager.TDelete(result);
            var values = JsonConvert.SerializeObject(result);
            return Json(values);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
