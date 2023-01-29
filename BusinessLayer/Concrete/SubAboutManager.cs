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
    public class SubAboutManager:ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Add(SubAbout entity)
        {
            _subAboutDal.insert(entity);
        }

        public void Delete(SubAbout entity)
        {
            _subAboutDal.delete(entity);
        }

        public SubAbout GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetList()
        {
            return _subAboutDal.list();
        }

        public void Update(SubAbout entity)
        {
            _subAboutDal.update(entity);
        }
    }
}
