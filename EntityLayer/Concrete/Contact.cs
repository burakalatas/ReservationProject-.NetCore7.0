using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string? ContactDescription { get; set; }
        public string? ContactMail { get; set; }
        public string? ContactAddress { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactMapLocation { get; set; }
        public bool ContactStatus { get; set; }
    }
}
