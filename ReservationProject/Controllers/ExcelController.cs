using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using ReservationProject.Models;

namespace ReservationProject.Controllers
{
    public class ExcelController : Controller
    {
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
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Report");
            workSheet.Cells[1, 1].Value = "Rota";
            workSheet.Cells[1, 2].Value = "Rehber";
            workSheet.Cells[1, 3].Value = "Kontenjan";

            workSheet.Cells[2, 1].Value = "Gürcistan-Batum Turu";
            workSheet.Cells[2, 2].Value = "Ahmet Yılmaz";
            workSheet.Cells[2, 3].Value = "50";

            workSheet.Cells[3, 1].Value = "Sırbistan-Makedonya Turu";
            workSheet.Cells[3, 2].Value = "Ayşe Yılmaz";
            workSheet.Cells[3, 3].Value = "40";

            var bytes = excel.GetAsByteArray();

            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Report.xlsx");
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
