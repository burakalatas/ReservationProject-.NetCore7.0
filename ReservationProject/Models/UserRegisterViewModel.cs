using System.ComponentModel.DataAnnotations;

namespace ReservationProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Kullanıcı soyadı boş geçilemez.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı e-posta adresi boş geçilemez.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Kullanıcı şifresi boş geçilemez.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Kullanıcı şifresi tekrarı boş geçilemez.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string RePassword { get; set; }
        [Required(ErrorMessage = "Kullanıcı telefon numarası boş geçilemez.")]
        public string PhoneNumber { get; set; }

    }
}
