using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
