using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AnnouncementController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IActionResult Index()
        {
            var values = announcementManager.GetAll();
            return View(values);
        }
        
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement p)
        {
            announcementManager.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult EditAnnouncement(Announcement p)
        {
            announcementManager.TUpdate(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var find = announcementManager.get(id);
            return View(find);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = announcementManager.get(id);
            announcementManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
