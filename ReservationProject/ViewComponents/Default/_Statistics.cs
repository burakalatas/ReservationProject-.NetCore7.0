using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.Guides = c.Guides.Count();
            ViewBag.Destinations = c.Destinations.Count();
            return View();
        }
    }
}
