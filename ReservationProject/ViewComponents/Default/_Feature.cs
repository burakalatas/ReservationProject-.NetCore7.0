using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager FeatureManager = new(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = FeatureManager.GetList();
            return View(values);
        }
    }
}
