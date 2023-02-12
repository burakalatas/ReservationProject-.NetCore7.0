using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ReservationProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new(new EfDestinationDal());

        ReservationManager reservationManager = new(new EfReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ActiveReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valueList = reservationManager.GetListWithReservationByAccepted(values.Id);
            return View(valueList);
        }
        public async Task<IActionResult> CompletedReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valueList = reservationManager.GetListWithReservationByOld(values.Id);
            return View(valueList);
        }
        public async Task<IActionResult> WaitingForApproveReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valueList = reservationManager.GetListWithReservationByWaitForApproval(values.Id);
            return View(valueList);
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.GetList()
                                           select new SelectListItem
                                           {
                                               Text = x.DestinationCity,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.list = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserId = 1;
            p.Status = "Onay bekliyor";
            reservationManager.Add(p);
            return RedirectToAction("ActiveReservations");
        }
    }
}
