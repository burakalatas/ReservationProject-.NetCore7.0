using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialAppBrand()
        {
            return PartialView();
        }
        public PartialViewResult PartialLeftMenu()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
    }
}
