using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.MemberDashboard
{
    public class _LastDestinations:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _LastDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.GetLast4Destination();
            return View(values);
        }
    }
}
