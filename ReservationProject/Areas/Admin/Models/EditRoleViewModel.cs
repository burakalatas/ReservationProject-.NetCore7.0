using System.ComponentModel.DataAnnotations;

namespace ReservationProject.Areas.Admin.Models
{
    public class EditRoleViewModel
    {
        [Required(ErrorMessage = "Rol adı giriniz.")]
        public string? RoleName { get; set; }
        public int RoleID { get; set; }
    }
}
