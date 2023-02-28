using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using ReservationProject.Models;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            try
            {
                MimeMessage message = new MimeMessage();

                MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "Mail Yollayacağımız mail adresi");
                message.From.Add(mailboxAddressFrom);

                MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
                message.To.Add(mailboxAddressTo);

                message.Subject = mailRequest.Subject;

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = mailRequest.Content;
                message.Body = bodyBuilder.ToMessageBody();

                SmtpClient client = new();
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("Mail Yollayacağımız mail adresi", "gmail Tarafında Ayarları Yaptıktan Sonra Bize Verilece Kodu Buraya Girmeliyiz");
                client.Send(message);
                client.Disconnect(true);


                return View();

            }
            catch (Exception)
            {
                return Content("Mail Gönderme Kısmı Henüz Aktif Edilmedi!");
            }
        }
    }
}
