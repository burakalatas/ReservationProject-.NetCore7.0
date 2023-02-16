using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialAppBrand()
        {
            return PartialView();
        }
    }
}
