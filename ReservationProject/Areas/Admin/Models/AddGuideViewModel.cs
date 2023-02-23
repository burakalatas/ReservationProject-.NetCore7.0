namespace ReservationProject.Areas.Admin.Models
{
    public class AddGuideViewModel
    {
        public int id { get; set; }
        public string? nameSurname { get; set; }
        public bool status { get; set; }
        public string? description { get; set; }
        public string? twitterUrl { get; set; }
        public string? instagramUrl { get; set; }
        public string? imageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
