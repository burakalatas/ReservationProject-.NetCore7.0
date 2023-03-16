using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public string? DestinationCity { get; set; }
        public string? DestinationStartingCity { get; set; }
        public string? DestinationDayNight { get; set; }
        public double DestinationPrice { get; set; }
        public string? DestinationImage { get; set; }
        public string? DestinationDescription { get; set; }
        public bool DestinationStatus { get; set; }
        public int DestinationCapacity { get; set; }
        public string? DestinationCoverImage { get; set; }
        public string? DestinationSubImage1 { get; set; }
        public string? DestinationSubImage2 { get; set; }
        public string? DestinationDetails { get; set; }
        public string? DestinationDetails2 { get; set; }
        public DateTime DestinationDate { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Reservation>? Reservations { get; set; }
        public int? GuideID { get; set; }
        public Guide? Guide { get; set; }
    }
}
