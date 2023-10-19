using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.ViewComponents.Dashboard
{
    public class FeatureStatictics : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Where(x => !x.Status).Count();
            ViewBag.v3 = context.Messages.Where(x => x.Status).Count();
            ViewBag.v4 = context.Portfolios.Count();
            return View();
        }
    }
}
