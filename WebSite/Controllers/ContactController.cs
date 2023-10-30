using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            var values = messageManager.GetAll();
            return View(values);
        }

        public IActionResult ContactDelete(int id)
        {
            var values = messageManager.get(id);
            messageManager.TDelete(values);
            return RedirectToAction("Index","contact");
        }

        [HttpGet]
        public IActionResult ContactDetails(int id)
        {
            var values = messageManager.get(id);
            return View(values);
        }
    }
}
