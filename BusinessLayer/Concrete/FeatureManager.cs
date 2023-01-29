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
    public class FeatureManager: IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature entity)
        {
            _featureDal.insert(entity);
        }

        public void Delete(Feature entity)
        {
            _featureDal.delete(entity);
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
            return _featureDal.list();
        }

        public void Update(Feature entity)
        {
            _featureDal.update(entity);
        }
    }
}
