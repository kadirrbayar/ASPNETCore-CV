using Microsoft.AspNetCore.Mvc;

namespace WebSite.ViewComponents.Header
{
    public class Header:ViewComponent
    {
        public IViewComponentResult Invoke() { 
            return View(); 
        }
    }
}
