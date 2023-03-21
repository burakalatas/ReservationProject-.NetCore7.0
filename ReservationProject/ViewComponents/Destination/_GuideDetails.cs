using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.Destination
{
    public class _GuideDetails:ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _guideService.GetById(id);
            return View(values);
        }
    }
}
