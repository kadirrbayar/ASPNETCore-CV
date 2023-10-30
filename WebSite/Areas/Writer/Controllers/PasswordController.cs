using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebSite.Areas.Writer.Models;

namespace WebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize(Roles = "Writer,Admin")]
    public class PasswordController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public PasswordController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserPasswordEditModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var signInResult = await _userManager.CheckPasswordAsync(user, p.OldPassword);
            if (signInResult)
            {
                if (p.Password == p.PasswordConfirm)
                {
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Yeni şifreler uyuşmuyor.");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Mevcut şifreniz yanlış.");
                return View();
            }
            return View();
        }
    }
}
