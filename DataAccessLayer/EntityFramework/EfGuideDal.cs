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
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public void ChangeStatus(int id)
        {
            using (var context = new Context())
            {
                var guide = context.Guides.Find(id);
                guide.GuideStatus = !guide.GuideStatus;
                context.SaveChanges();
            }
        }
    }
}
