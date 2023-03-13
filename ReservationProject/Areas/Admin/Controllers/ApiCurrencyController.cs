using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReservationProject.Areas.Admin.Models;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ApiCurrencyController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ApiCurrencyViewModel apiCurrency = new();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-converter-by-api-ninjas.p.rapidapi.com/v1/convertcurrency?have=USD&want=TRY&amount=1"),
                Headers =
    {
        { "X-RapidAPI-Key", "513ca23f55msh016a882aa956bc5p1d3ba0jsn2309b7db97f5" },
        { "X-RapidAPI-Host", "currency-converter-by-api-ninjas.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiCurrency = JsonConvert.DeserializeObject<ApiCurrencyViewModel>(body);

                return View(apiCurrency);
            }
        }
    }
}
