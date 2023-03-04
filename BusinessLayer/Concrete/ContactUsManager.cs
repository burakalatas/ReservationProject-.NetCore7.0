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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void Add(ContactUs entity)
        {
            _contactUsDal.insert(entity);
        }

        public void ContactUsChangeStatus(int id)
        {
            _contactUsDal.ContactUsChangeStatus(id);
        }

        public void Delete(ContactUs entity)
        {
            _contactUsDal.delete(entity);
        }

        public ContactUs GetById(int id)
        {
            return _contactUsDal.GetById(id);
        }

        public List<ContactUs> GetList()
        {
            return _contactUsDal.list();
        }

        public List<ContactUs> GetListByFalse()
        {
            return _contactUsDal.GetListByFalse();
        }

        public List<ContactUs> GetListByTrue()
        {
            return _contactUsDal.GetListByTrue();
        }

        public void Update(ContactUs entity)
        {
            _contactUsDal.update(entity);
        }
    }
}
