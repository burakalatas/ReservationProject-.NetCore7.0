using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Controllers
{
    public class PdfController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "StaticPdfReport.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Rezervasyon projesi statik pdf raporu.");

            document.Add(paragraph);

            document.Close();

            return File("/PdfReports/StaticPdfReport.pdf", "application/pdf", "StaticPdfReport.pdf");

        }
        public IActionResult StaticCustomerPdfReport()
        {
            string Arial_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");
            BaseFont bf = BaseFont.CreateFont(Arial_TFF, BaseFont.IDENTITY_H, true);
            Font f = new Font(bf, 12, Font.NORMAL);

            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "StaticCustomerPdfReport.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable table = new PdfPTable(3);
            table.AddCell(new Phrase("Üye Adı", f));
            table.AddCell(new Phrase("Üye Soyadı", f));
            table.AddCell(new Phrase("Üye TC", f));

            table.AddCell(new Phrase("Ahmet", f));
            table.AddCell(new Phrase("Yılmaz", f));
            table.AddCell(new Phrase("01234567891", f));

            table.AddCell(new Phrase("Seda", f));
            table.AddCell(new Phrase("Yıldız", f));
            table.AddCell(new Phrase("12345678901", f));

            document.Add(table);

            document.Close();

            return File("/PdfReports/StaticCustomerPdfReport.pdf", "application/pdf", "StaticCustomerPdfReport.pdf");
        }
    }
}
