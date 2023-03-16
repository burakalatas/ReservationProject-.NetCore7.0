using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.GetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
