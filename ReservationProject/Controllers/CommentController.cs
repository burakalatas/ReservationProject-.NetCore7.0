using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            commentManager.Add(comment);
            return Redirect(Url.Action("DestinationDetails", "Destination", new { id = comment.DestinationID })+"#yorumlar");
        }
    }
}
