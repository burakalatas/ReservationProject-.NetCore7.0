using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
