using System.ComponentModel.DataAnnotations;

namespace WebSite.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadı alanı boş geçilemez")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Görsel URL alanı boş geçilemez")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı boş geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]

        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Mail alanı boş geçilemez.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Görsel alanı boş geçilemez.")]
        public IFormFile Image { get; set; }

    }
}
