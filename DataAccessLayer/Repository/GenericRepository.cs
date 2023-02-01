using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public void insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public List<T> list()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
