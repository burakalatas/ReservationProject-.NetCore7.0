using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuideManager guideManager = new(new EfGuideDal());
        public IActionResult Index()
        {
            var values = guideManager.GetList();
            return View(values);
        }
    }
}
