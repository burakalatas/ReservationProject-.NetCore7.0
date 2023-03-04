using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var values = _contactUsService.GetListByTrue();
            return View(values);
        }
        public IActionResult ReadMessages()
        {
            var values = _contactUsService.GetListByFalse();
            return View(values);
        }
        public IActionResult ChangeStatusIndex(int id)
        {
            _contactUsService.ContactUsChangeStatus(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusReadMessages(int id)
        {
            _contactUsService.ContactUsChangeStatus(id);
            return RedirectToAction("ReadMessages");
        }
    }
}
