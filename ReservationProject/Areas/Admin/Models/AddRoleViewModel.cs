using System.ComponentModel.DataAnnotations;

namespace ReservationProject.Areas.Admin.Models
{
    public class AddRoleViewModel
    {
        [Required(ErrorMessage = "Rol adı giriniz.")]
        public string? RoleName { get; set; }
    }
}
