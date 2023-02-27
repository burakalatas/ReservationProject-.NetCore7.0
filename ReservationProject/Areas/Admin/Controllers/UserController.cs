using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class UserController : Controller
    {
        private readonly IAppUserService _userService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService userService, IReservationService reservationService)
        {
            _userService = userService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _userService.GetList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var userValue = _userService.GetById(id);
            _userService.Delete(userValue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var userValue = _userService.GetById(id);
            return View(userValue);
        }
        [HttpPost]
        public IActionResult EditUser(AppUser user)
        {
            _userService.Update(user);
            return RedirectToAction("Index");
        }
        public IActionResult CommentHistory(int id) 
        {
            return View();
        }
        public IActionResult ReservationHistory(int id)
        {
            var values = _reservationService.GetListByUserId(id);
            var name = _userService.GetById(id).Name;
            var surname = _userService.GetById(id).Surname;
            ViewBag.nameSurname = name + " " + surname;
            return View(values);
        }

    }
}
