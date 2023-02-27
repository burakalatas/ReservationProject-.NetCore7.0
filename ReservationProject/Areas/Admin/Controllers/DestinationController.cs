using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetList();
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
            _destinationService.Add(destination);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditDestination(int id)
        {
            var destinationValue = _destinationService.GetById(id);
            return View(destinationValue);
        }
        [HttpPost]
        public IActionResult EditDestination(Destination destination)
        {
            _destinationService.Update(destination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            var destinationValue = _destinationService.GetById(id);
            _destinationService.Delete(destinationValue);
            return RedirectToAction("Index");
        }
    }
}
