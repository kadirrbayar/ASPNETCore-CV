using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = socialMediaManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult SocialMediaAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SocialMediaAdd(SocialMedia socialMedia)
        {
            socialMedia.Status = true;
            socialMediaManager.TAdd(socialMedia);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult SocialMediaEdit(int id)
        {
            var values = socialMediaManager.get(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult SocialMediaEdit(SocialMedia socialMedia)
        {
            socialMedia.Status = true;
            socialMediaManager.TUpdate(socialMedia);
            return RedirectToAction("Index", "socialmedia");
        }
        public IActionResult SocialMediaDelete(int id)
        {
            var values = socialMediaManager.get(id);
            socialMediaManager.TDelete(values);
            return RedirectToAction("Index", "socialmedia");
        }
    }
}
