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
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void ChangeStatus(int id)
        {
            using (var c = new Context())
            {
                var value = c.Announcements.Find(id);
                value.AnnouncementStatus = !value.AnnouncementStatus;
                
                c.SaveChanges();
            }
        }
    }
}
