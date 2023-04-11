using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using ReservationProject.Models;

namespace ReservationProject.Controllers
{
    [AllowAnonymous]
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public PasswordChangeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Email);

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                var passwordResetLink = Url.Action("ResetPassword", "PasswordChange", new { userId = user.Id, token = token }, Request.Scheme);


                MimeMessage message = new MimeMessage();

                MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "Mail Yollayacağımız mail adresi");
                message.From.Add(mailboxAddressFrom);

                MailboxAddress mailboxAddressTo = new MailboxAddress("User", forgetPasswordViewModel.Email);
                message.To.Add(mailboxAddressTo);

                message.Subject = "Şifre Değişiklik Talebi";

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = passwordResetLink;
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

                return Content("Modül aktif değil!");
            }

        }
        [HttpGet]
        public IActionResult ResetPassword(string userId, string token)
        {
            TempData["userid"] = userId;
            TempData["token"] = token;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            var userid = TempData["userid"];
            var token = TempData["token"];

            if (userid == null || token == null)
            {
                return Content("Error!");
            }

            var user = await _userManager.FindByIdAsync(userid.ToString());
            var result = await _userManager.ResetPasswordAsync(user, token.ToString(), resetPasswordViewModel.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }
    }
}
