using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRChartApi.DAL;
using SignalRChartApi.Models;

namespace SignalRChartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {

        private readonly VisitorService _visitorService;

        public VisitorController(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        [HttpGet]
        public IActionResult CreateVisitors()
        {
            Random random = new();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (ECity item in Enum.GetValues(typeof(ECity)))
                {
                    var newVisitor = new Visitor
                    {
                        VisitDate = DateTime.Now.AddDays(-x),
                        //VisitDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-x)),
                        City = item,
                        CityVisitCount = random.Next(100, 2000)
                    };
                    _visitorService.AddVisitor(newVisitor).Wait();
                    System.Threading.Thread.Sleep(1000);
                }
            });
            return Ok("Ziyaretçiler başarılı bir şekilde eklendi.");
        }
    }
}
