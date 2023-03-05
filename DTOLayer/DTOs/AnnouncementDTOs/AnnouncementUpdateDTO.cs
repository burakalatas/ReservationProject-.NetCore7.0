using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AnnouncementDTOs
{
    public class AnnouncementUpdateDTO
    {
        public int AnnouncementId { get; set; }
        public string? AnnouncementTitle { get; set; }
        public string? AnnouncementContent { get; set; }
        public DateTime AnnouncementDate { get; set; }
    }
}
