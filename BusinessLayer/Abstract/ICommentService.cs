using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        List<Comment> GetListByDestinationId(int id);
        List<Comment> GetListCommentWithDestination();
        public List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}
