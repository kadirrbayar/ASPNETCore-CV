using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage()
        {
            string p = "";
            p = "admin@admin.com";
            var messageList = writerMessageManager.getReceiverMessage(x => x.Receiver == p);
            return View(messageList);
        }

        public async Task<IActionResult> SenderMessage()
        {
            string p;
            p = "admin@admin.com";
            var messageList = writerMessageManager.getSenderMessage(x => x.Sender == p);
            return View(messageList);
        }

        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.get(id);
            return View(writerMessage);
        }

        [HttpGet]
        public IActionResult MessageAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MessageAdd(WriterMessage p)
        {
            string mail = "admin@admin.com";
            string name = "Admin";
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            p.ReceiverName = c.Users.Where(c => c.Email == p.Receiver).Select(y => y.Name + " " + y.SurName).FirstOrDefault();
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }

        public IActionResult MessageDelete(int id)
        {
            var values = writerMessageManager.get(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("SenderMessage");
        }
    }
}
