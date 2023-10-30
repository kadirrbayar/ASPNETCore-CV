using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.ViewComponents.Dashboard
{
    public class AdminHead:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;
        public AdminHead(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            ViewBag.v = values.ImageURL;
            ViewBag.v1 = values.Name + ' ' + values.SurName;
            return View(values);
        }
    }
}
