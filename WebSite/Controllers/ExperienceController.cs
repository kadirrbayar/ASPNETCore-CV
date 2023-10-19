using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = experienceManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult ExperienceAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ExperienceAdd(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ExperienceEdit(int id)
        {
            var values = experienceManager.get(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult ExperienceEdit(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
        public IActionResult ExperienceDelete(int id)
        {
            var values = experienceManager.get(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }

    }
}
