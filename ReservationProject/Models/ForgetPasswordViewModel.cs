using System.ComponentModel.DataAnnotations;

namespace ReservationProject.Models
{
    public class ForgetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
