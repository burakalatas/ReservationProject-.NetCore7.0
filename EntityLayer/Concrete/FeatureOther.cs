using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FeatureOther
    {
        [Key]
        public int FeatureOthersID { get; set; }
        public string? FeatureOthersTitle { get; set; }
        public string? FeatureOthersDescription { get; set; }
        public string? FeatureOthersImage { get; set; }
        public bool FeatureOthersStatus { get; set; }
    }
}
