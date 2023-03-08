using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraversalApiProject.DAL.Context;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        [HttpGet]
        public IActionResult VisitorList()
        {
            using (var db = new VisitorContext())
            {
                var visitors = db.Visitors.ToList();
                return Ok(visitors);
            }
        }
        [HttpPost]
        public IActionResult AddVisitor(Visitor visitor)
        {
            using (var db = new VisitorContext())
            {
                db.Visitors.Add(visitor);
                db.SaveChanges();
                return Ok();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetVisitor(int id)
        {
            using (var db = new VisitorContext())
            {
                var values = db.Visitors.Find(id);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(values);
                }
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteVisitor(int id)
        {
            using (var db = new VisitorContext())
            {
                var values = db.Visitors.Find(id);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    db.Visitors.Remove(values);
                    db.SaveChanges();
                    return Ok();
                }
            }
        }
        [HttpPut]
        public IActionResult UpdateVisitor(Visitor visitor)
        {
            using (var db = new VisitorContext())
            {
                var values = db.Find<Visitor>(visitor.VisitorID);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    if (visitor.VisitorName!="string")
                    {
                        values.VisitorName = visitor.VisitorName;
                    }
                    if (visitor.VisitorSurname != "string")
                    {
                        values.VisitorSurname = visitor.VisitorSurname;
                    }
                    if (visitor.VisitorMail != "string")
                    {
                        values.VisitorMail = visitor.VisitorMail;
                    }
                    if (visitor.VisitorCity != "string")
                    {
                        values.VisitorCity = visitor.VisitorCity;
                    }
                    if (visitor.VisitorCountry != "string")
                    {
                        values.VisitorCountry = visitor.VisitorCountry;
                    }


                    db.Update(values);
                    db.SaveChanges();
                    return Ok();
                }
            }
        }
    }
}
