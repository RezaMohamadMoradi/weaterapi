using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Web_mvc_WeaterApi.Models;

namespace Web_mvc_WeaterApi.Controllers
{
    public class WeatherController : Controller
    {
        private const string apiKey = "faacda6ecd57682b6dc0b9e82a0a6ca6"; // کلید API خود را اینجا وارد کنید

        // GET: Weather
        // Controllers/WeatherController.cs
        public async Task<IActionResult> Index(string city = "Tehran")
        {
            ViewBag.City = city; // مقدار شهر ورودی را به ViewBag اضافه می‌کنیم.

            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    WeatherInfo weather = JsonConvert.DeserializeObject<WeatherInfo>(data);

                    return View(weather);
                }
                else
                {
                    ViewBag.Error = "Error: Unable to fetch weather data.";
                    return View();
                }
            }
        }
     
    }
}
