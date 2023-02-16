using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            destinationManager.Add(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
        [HttpGet]
        public IActionResult EditDestination(int id)
        {
            var destinationValue = destinationManager.GetById(id);
            return View(destinationValue);
        }
        [HttpPost]
        public IActionResult EditDestination(Destination destination)
        {
            destinationManager.Update(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
        public IActionResult DeleteDestination(int id)
        {
            var destinationValue = destinationManager.GetById(id);
            destinationManager.Delete(destinationValue);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
    }
}
