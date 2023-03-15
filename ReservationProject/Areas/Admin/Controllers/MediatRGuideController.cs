using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReservationProject.CQRS.Commands.GuideCommands;
using ReservationProject.CQRS.Queries.GuideQueries;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class MediatRGuideController : Controller
    {
        private readonly IMediator _mediator;

        public MediatRGuideController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _mediator.Send(new GetAllGuideQuery());
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetGuidesById(int id)
        {
            var result = await _mediator.Send(new GetGuideByIdQuery(id));
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> GetGuidesById(UpdateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateGuide()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateGuide(CreateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteGuide(int id)
        {
            await _mediator.Send(new DeleteGuideCommand(id));
            return RedirectToAction("Index");
        }
    }
}
