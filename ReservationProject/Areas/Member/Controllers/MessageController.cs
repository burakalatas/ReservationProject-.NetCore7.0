using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
