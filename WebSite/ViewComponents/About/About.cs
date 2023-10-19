using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.ViewComponents.About
{
    public class About : ViewComponent
    {
        AboutManager manager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.GetAll();
            return View(values);
        }
    }
}
