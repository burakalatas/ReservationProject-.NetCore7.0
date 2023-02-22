using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.AdminDashboard
{
    public class _Card1Statistics:ViewComponent
    {
        Context c = new();
        public IViewComponentResult Invoke()
        {
            ViewBag.TotalUsers = c.Users.Count();
            ViewBag.TotalDestinations = c.Destinations.Count();

            return View();
        }
    }
}
