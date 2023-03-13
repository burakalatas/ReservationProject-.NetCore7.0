namespace ReservationProject.Areas.Admin.Models
{
    public class ApiMovieViewModel
    {
        public int rank { get; set; }
        public string? title { get; set; }
        public string? thumbnail { get; set; }
        public string? rating { get; set; }
        public string? year { get; set; }
        public string? trailer { get; set; }
        public List<string> genre { get; set; }
    }
}
