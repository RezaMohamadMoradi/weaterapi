using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace test.Repository

{
    public class weater_test
    {
        [HttpPost]
        static async Task Main(string[] args)
        {
            string apiKey = "faacda6ecd57682b6dc0b9e82a0a6ca6"; // کلید API خود را اینجا وارد کنید
            string cityName = "Tehran"; // نام شهر
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        // تبدیل JSON به مدل
                        WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(responseData);

                        // نمایش اطلاعات
                        Console.WriteLine($"City: {weatherInfo.Name}");
                        Console.WriteLine($"Temperature: {weatherInfo.Main.Temp}°C");
                        Console.WriteLine($"Humidity: {weatherInfo.Main.Humidity}%");
                        Console.WriteLine($"Weather: {weatherInfo.Weather[0].Description}");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    // مدل‌ها برای داده‌های API
    public class WeatherInfo
    {
        public MainInfo Main { get; set; }
        public Weather[] Weather { get; set; }
        public string Name { get; set; }
    }

    public class MainInfo
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
    }

}

