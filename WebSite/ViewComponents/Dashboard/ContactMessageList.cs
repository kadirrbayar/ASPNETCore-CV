using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.ViewComponents.Dashboard
{
    public class ContactMessageList : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.GetAll().Take(5).ToList();
            return View(values);
        }
    }
}
