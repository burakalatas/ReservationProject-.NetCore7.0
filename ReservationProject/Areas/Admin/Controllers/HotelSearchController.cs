using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReservationProject.Areas.Admin.Models;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class HotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?checkin_date=2023-09-05&checkout_date=2023-09-06&filter_by_currency=TRY&dest_id=-1456928&room_number=1&units=metric&dest_type=city&locale=en-gb&adults_number=2&order_by=popularity&page_number=0&children_number=2&include_adjacency=true&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
                Headers =
    {
        { "X-RapidAPI-Key", "513ca23f55msh016a882aa956bc5p1d3ba0jsn2309b7db97f5" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<HotelSearchViewModel>(body);
                return View(values.results);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetCityDestID()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> GetCityDestID(string p)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={p}&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "513ca23f55msh016a882aa956bc5p1d3ba0jsn2309b7db97f5" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return View();
            }
        }
    }
}
