using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericUowDal<T> where T : class
    {
        void insert(T t);
        void update(T t);
        void MultiUpdate(List<T> t);
        T GetById(int id);
    }
}
