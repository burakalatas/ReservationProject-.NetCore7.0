using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReservationProject.Areas.Admin.Models;
using System.Text;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class VisitorController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public VisitorController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:53336/api/Visitor");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Visitor>>(jsonData);
                return View(values);
            }

            return View();
        }
        [HttpGet]
        public IActionResult AddVisitor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddVisitor(Visitor visitor)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(visitor);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("http://localhost:53336/api/Visitor",content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"http://localhost:53336/api/Visitor/{id}");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateVisitor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"http://localhost:53336/api/Visitor/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Visitor>(jsonData);
                return View(values);
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateVisitor(Visitor visitor)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(visitor);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("http://localhost:53336/api/Visitor/",content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
