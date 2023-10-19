using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult SkillAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SkillAdd(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

        public IActionResult SkillDelete(int id)
        {
            var values = skillManager.get(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SkillEdit(int id)
        {
            var values = skillManager.get(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult SkillEdit(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
