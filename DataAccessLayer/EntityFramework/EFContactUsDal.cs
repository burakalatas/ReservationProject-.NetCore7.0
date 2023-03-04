using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ContactUsChangeStatus(int id)
        {
            using (var c = new Context())
            {
                var value = c.ContactUses.Find(id);
                value.ContactUsStatus = !value.ContactUsStatus;
                c.SaveChanges();
            }
        }

        public List<ContactUs> GetListByFalse()
        {
            using (var c = new Context())
            {
                return c.ContactUses.Where(x => x.ContactUsStatus == false).ToList();
            }
        }

        public List<ContactUs> GetListByTrue()
        {
            using (var c = new Context())
            {
                return c.ContactUses.Where(x => x.ContactUsStatus == true).ToList();
            }
        }
    }
}
