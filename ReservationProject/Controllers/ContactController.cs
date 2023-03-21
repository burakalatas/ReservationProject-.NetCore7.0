using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.Add(new ContactUs
                {
                    UserName = model.UserName,
                    UserMail = model.UserMail,
                    Message = model.Message,
                    Subject = model.Subject,
                    ContactUsDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    ContactUsStatus = false
                });
                return RedirectToAction("Index","Default");
            }
            else
            {
                return View(model);
            }
        }
    }
}
