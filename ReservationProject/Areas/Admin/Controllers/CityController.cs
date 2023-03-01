using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReservationProject.Models;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetList());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult CityAdd(Destination destination)
        {
            _destinationService.Add(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }
        public IActionResult CityGetById(int DestinationID)
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.GetById(DestinationID));
            return Json(jsonCity);
        }
        public IActionResult CityDelete(int id)
        {
            var city = _destinationService.GetById(id);
            _destinationService.Delete(city);
            return NoContent();
        }
        [HttpPost]
        public IActionResult CityUpdate(Destination destination)
        {
            _destinationService.Update(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }
    }
}
