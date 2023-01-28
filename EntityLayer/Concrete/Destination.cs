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
    }
}
