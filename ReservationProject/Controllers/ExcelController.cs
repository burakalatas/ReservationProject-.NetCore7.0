using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using ReservationProject.Models;

namespace ReservationProject.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<ExcelDestinationModel> DestinationList()
        {
            List<ExcelDestinationModel> excelDestinationModels = new List<ExcelDestinationModel>();
            using (var c = new Context())
            {
                excelDestinationModels = c.Destinations.Select(x => new ExcelDestinationModel
                {
                    EndCity = x.DestinationCity,
                    StartCity = x.DestinationStartingCity,
                    DayNight = x.DestinationDayNight,
                    Capacity = x.DestinationCapacity,
                    Price = x.DestinationPrice
                }).ToList();
            }
            return excelDestinationModels;
        }
        
        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Report.xlsx");
            
        }
        
        public IActionResult DestinationExcelReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Tur Listesi");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Başlangıç Şehri";
                worksheet.Cell(currentRow, 2).Value = "Bitiş Şehri";
                worksheet.Cell(currentRow, 3).Value = "Gece/Gün";
                worksheet.Cell(currentRow, 4).Value = "Kontenjan";
                worksheet.Cell(currentRow, 5).Value = "Fiyat";

                foreach (var item in DestinationList())
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.StartCity;
                    worksheet.Cell(currentRow, 2).Value = item.EndCity;
                    worksheet.Cell(currentRow, 3).Value = item.DayNight;
                    worksheet.Cell(currentRow, 4).Value = item.Capacity;
                    worksheet.Cell(currentRow, 5).Value = "$" + item.Price;

                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "TurListesi.xlsx");
                }
            }
        }
    }
}
