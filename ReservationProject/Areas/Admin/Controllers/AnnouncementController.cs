using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using ReservationProject.Areas.Admin.Models;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.GetList());

            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.Add(new Announcement {
                    AnnouncementTitle = model.AnnouncementTitle,
                    AnnouncementContent = model.AnnouncementContent,
                    AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    AnnouncementStatus = false
                });
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var value = _announcementService.GetById(id);
            _announcementService.Delete(value);
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDTO>(_announcementService.GetById(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.Update(new Announcement
                {
                    AnnouncementID = model.AnnouncementId,
                    AnnouncementContent = model.AnnouncementContent,
                    AnnouncementTitle = model.AnnouncementTitle,
                    AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            else
                return View(model);
        }
        public IActionResult ChangeStatus(int id)
        {
            _announcementService.ChangeStatus(id);
    
            return RedirectToAction("Index");
        }

    }
}
