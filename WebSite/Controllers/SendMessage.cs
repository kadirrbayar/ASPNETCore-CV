using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebSite.Controllers
{
    public class SendMessage : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        [HttpPost]
        public IActionResult MessageAdd(Message p)
        {
            p.Date = DateTime.Now;
            p.Status = true;
            messageManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
