using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Windows.Markup;

namespace WebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/{controller}/{action}/{id?}")]
    [Authorize(Roles = "Writer,Admin")]

    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.getReceiverMessage(x => x.Receiver == p);
            return View(messageList);
        }

        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.getSenderMessage(x => x.Sender == p);
            return View(messageList);
        }

        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.get(id);
            return View(writerMessage);
        }

        public IActionResult SenderMessageDetails(int id)
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
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.SurName;
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            p.ReceiverName = c.Users.Where(c => c.Email == p.Receiver).Select(y => y.Name + " " + y.SurName).FirstOrDefault();
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
