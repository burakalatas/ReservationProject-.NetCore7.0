using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager:ITestimonialService
    {
        ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial entity)
        {
            _testimonialDal.insert(entity);
        }

        public void Delete(Testimonial entity)
        {
            _testimonialDal.delete(entity);
        }

        public Testimonial GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.list();
        }

        public void Update(Testimonial entity)
        {
            _testimonialDal.update(entity);
        }
    }
}
