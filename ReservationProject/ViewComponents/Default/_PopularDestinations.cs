using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        DestinationManager destinationManager = new(new EfDestinationDal()); 
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.GetList().Take(6);
            return View(values);
        }
    }
}
