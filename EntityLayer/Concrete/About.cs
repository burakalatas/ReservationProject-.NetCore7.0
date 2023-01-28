using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutTitle2 { get; set; }
        public string? AboutDescription { get; set; }
        public string? AboutDescription2 { get; set; }
        public string? AboutImage1 { get; set; }
        public bool Status { get; set; }
    }
}
