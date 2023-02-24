using System.ComponentModel.DataAnnotations;

namespace ReservationProject.Areas.Admin.Models
{
    public class AddGuideViewModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Rehber adı boş geçilemez!")]
        [MaxLength(50, ErrorMessage = "Rehber adı 50 karakterden uzun olamaz!")]
        [MinLength(3, ErrorMessage = "Rehber adı 3 karakterden kısa olamaz!")]
        public string? nameSurname { get; set; }
        public bool status { get; set; }
        [Required(ErrorMessage = "Açıklama alanı boş geçilemez!")]
        [MaxLength(300, ErrorMessage = "Açıklama alanı 300 karakterden uzun olamaz!")]
        public string? description { get; set; }
        public string? twitterUrl { get; set; }
        public string? instagramUrl { get; set; }
        public string? imageUrl { get; set; }
        public IFormFile? Image { get; set; }
    }
}
