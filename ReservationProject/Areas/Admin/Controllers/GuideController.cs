using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ReservationProject.Areas.Admin.Models;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuide(AddGuideViewModel p)
        {
            Guide newGuide = new();
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/guideimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                newGuide.GuideImage = imagename;
            }
            
            newGuide.GuideDescription = p.description;
            newGuide.GuideStatus = p.status;
            newGuide.GuideName = p.nameSurname;
            newGuide.GuideTwitterURL = p.twitterUrl;
            newGuide.GuideInstagramURL = p.instagramUrl;
            
            if (ModelState.IsValid)
            {
                _guideService.Add(newGuide);
            }
            else
            {
                return View(p);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.GetById(id);

            AddGuideViewModel addGuideViewModel = new AddGuideViewModel
            {
                id = values.GuideID,
                nameSurname = values.GuideName,
                description = values.GuideDescription,
                status = values.GuideStatus,
                twitterUrl = values.GuideTwitterURL,
                instagramUrl = values.GuideInstagramURL,
                imageUrl = values.GuideImage
            };

            return View(addGuideViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditGuide(AddGuideViewModel p)
        {
            var values = _guideService.GetById(p.id);
            
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/guideimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                values.GuideImage = imagename;
            }
            
            values.GuideDescription = p.description;
            values.GuideStatus = p.status;
            values.GuideName = p.nameSurname;
            values.GuideTwitterURL = p.twitterUrl;
            values.GuideInstagramURL = p.instagramUrl;

            if (ModelState.IsValid)
            {
                _guideService.Update(values);
            }
            else
            {
                return View(p);
            }
            
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatus(int id)
        {
            return RedirectToAction("Index");
        }
        public IActionResult DeleteGuide(int id)
        {
            var values = _guideService.GetById(id);
            _guideService.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
