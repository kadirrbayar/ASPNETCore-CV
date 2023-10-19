using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace WebSite.ViewComponents.Dashboard
{
    public class AdminMessageList:ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public IViewComponentResult Invoke()
        {
            var p = "admin@admin.com";
            var values = writerMessageManager.getReceiverMessage(x => x.Receiver == p).OrderByDescending(x => x.MessageId).Take(3).ToList();
            ViewBag.v1 = writerMessageManager.getReceiverMessage(x => x.Receiver == p).Count();
            return View(values);
        }
    }
}
