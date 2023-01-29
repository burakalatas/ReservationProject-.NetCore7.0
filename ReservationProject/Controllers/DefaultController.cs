using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
