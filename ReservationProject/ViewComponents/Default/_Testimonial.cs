using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        TestimonialManager testimonialManager = new(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.GetList();
            return View(values);
        }
    }
}
