using System.ComponentModel.DataAnnotations;

namespace WebSite.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı boş geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        public string SurName { get; set; }
        
        [Required(ErrorMessage = "Şifre tekrar alanı boş geçilemez")]
        public string PasswordConfirm { get; set; }
        
        [Required(ErrorMessage = "Görsel alanı boş geçilemez")]
        public string ImageUrl { get; set; }
        
        [Required(ErrorMessage = "Görsel alanı boş geçilemez")]
        public IFormFile Image { get; set; }
    }
}
