using System.ComponentModel.DataAnnotations;

namespace WebSite.Areas.Writer.Models
{
    public class UserPasswordEditModel
    {
        [Required(ErrorMessage = "Mevcut şifre alanı boş geçilemez.")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanı boş geçilemez")]
        public string PasswordConfirm { get; set; }
    }
}
