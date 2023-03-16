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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment entity)
        {
            _commentDal.insert(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.delete(entity);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.list();
        }
        public List<Comment> GetListByDestinationId(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationID == id);
        }

        public List<Comment> GetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);
        }

        public void Update(Comment entity)
        {
            _commentDal.update(entity);
        }
    }
}
