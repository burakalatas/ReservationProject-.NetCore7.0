using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.ContactDTOs
{
    public class SendMessageDto
    {
        public string? UserName { get; set; }
        public string? UserMail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime ContactUsDate { get; set; }
        public bool ContactUsStatus { get; set; }
    }
}
