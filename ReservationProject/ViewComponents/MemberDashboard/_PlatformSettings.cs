using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.MemberDashboard
{
    public class _PlatformSettings:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
