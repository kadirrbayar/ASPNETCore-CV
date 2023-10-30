using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.ViewComponents.Dashboard
{
    public class PortfolioSlide:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;
        
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public PortfolioSlide(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = portfolioManager.GetAll();
            var users = await _userManager.FindByNameAsync(User.Identity?.Name);
            ViewBag.v = users.ImageURL;
            ViewBag.v1 = users.Name + ' ' + users.SurName;
            return View(values);
        }
    }
}
