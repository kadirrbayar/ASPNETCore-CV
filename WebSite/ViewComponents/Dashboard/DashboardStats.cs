using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.ViewComponents.Dashboard
{
    public class DashboardStats:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke() 
        {
            ViewBag.v1 = context.Messages.Count();
            ViewBag.v2 = context.Testimonials.Count();
            ViewBag.v3 = context.Services.Count();
            return View(); 
        }
    }
}
