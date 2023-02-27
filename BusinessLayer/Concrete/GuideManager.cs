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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void Add(Guide entity)
        {
            _guideDal.insert(entity);
        }

        public void ChangeStatus(int id)
        {
            _guideDal.ChangeStatus(id);
        }

        public void Delete(Guide entity)
        {
            _guideDal.delete(entity);
        }

        public Guide GetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public List<Guide> GetList()
        {
            return _guideDal.list();
        }

        public void Update(Guide entity)
        {
            _guideDal.update(entity);
        }
    }
}
