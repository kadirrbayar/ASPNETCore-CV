using Microsoft.AspNetCore.Mvc;

namespace WebSite.ViewComponents.Menu
{
    public class Menu:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
