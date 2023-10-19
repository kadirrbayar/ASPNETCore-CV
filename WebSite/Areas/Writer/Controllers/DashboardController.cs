using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/{controller}/{action}")]
    [Authorize(Roles = "Writer,Admin")]

    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.SurName;

            //Weather API
            string api = "69fa5dfac7c9a31c29ff7694e6be51d9";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=kutahya&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //Statistics
            Context c = new Context();
            ViewBag.v1 = c.WriterMessages.Where(x => x.Receiver == values.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.WriterMessages.Where(x => x.Sender == values.Email).Count();
            ViewBag.v4 = c.Users.Count();

            return View();
        }
    }
}
