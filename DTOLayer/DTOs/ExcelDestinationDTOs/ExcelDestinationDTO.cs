using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.ExcelDestinationDTOs
{
    public class ExcelDestinationDTO
    {
        public string? EndCity { get; set; }
        public string? StartCity { get; set; }
        public string? DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
