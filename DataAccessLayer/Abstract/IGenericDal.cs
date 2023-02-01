using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void insert(T t);
        void delete(T t);
        void update(T t);
        List<T> list();
        T GetById(int id);
        List<T> GetListByFilter(Expression<Func<T,bool>>filter);
    }
}
