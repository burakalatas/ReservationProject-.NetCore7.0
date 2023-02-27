using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReservationProject.Areas.Member.Models;

namespace ReservationProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]/{id?}")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel
            {
                name = values.Name,
                surname = values.Surname,
                mailAddress = values.Email,
                phonenumber = values.PhoneNumber
            };
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            if (p.mailAddress !=null)
            {
                user.Email = p.mailAddress;
            }
            if (p.phonenumber != null)
            {
                user.PhoneNumber = p.phonenumber;
            }
            if (p.name != null)
            {
                user.Name = p.name;
            }
            if (p.surname != null)
            {
                user.Surname = p.surname;
            }
            if (p.password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            }

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn","Login");
            }
            return View(p);
        }
    }
}
