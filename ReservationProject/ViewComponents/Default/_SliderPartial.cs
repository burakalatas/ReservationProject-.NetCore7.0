using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
