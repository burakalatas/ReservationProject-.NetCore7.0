using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.GetListCommentWithDestination();
            return View(values);
        }
        public IActionResult DeleteComment(int id)
        {
            var commentValue = _commentService.GetById(id);
            _commentService.Delete(commentValue);
            return RedirectToAction("Index");
        }
    }
}
