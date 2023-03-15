using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.AbstractUow
{
    public interface IGenericUowService<T>
    {
        void insert(T t);
        void update(T t);
        void MultiUpdate(List<T> t);
        T GetById(int id);
    }
}
