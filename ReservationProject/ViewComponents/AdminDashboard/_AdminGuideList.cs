using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.AdminDashboard
{
    public class _AdminGuideList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
