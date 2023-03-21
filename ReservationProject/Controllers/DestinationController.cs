using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new(new EfDestinationDal());
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = destinationManager.GetList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var value = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.userID = value.Id;
            }

            ViewBag.id = id;
            var values = destinationManager.GetDestinationWithGuide(id);
            ViewBag.GuideID = values.GuideID;
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();

        }
    }
}
