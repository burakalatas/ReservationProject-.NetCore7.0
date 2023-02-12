using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        GuideManager guideManager = new(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = guideManager.GetList();
            return View(values);
        }
    }
}
