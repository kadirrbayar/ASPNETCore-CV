using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebSite.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var v = experienceManager.GetAll();
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        [HttpPost]
        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.get(id);
            experienceManager.TDelete(v);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
    }
}
