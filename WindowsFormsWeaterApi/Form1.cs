using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWeaterApi
{
    public partial class Form1 : Form
    {
        // کلید API شما (آن را جایگزین کنید)
        private const string apiKey = "faacda6ecd57682b6dc0b9e82a0a6ca6";

        public Form1()
        {
            InitializeComponent();
        }

       
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

        private async void btnGetWeather_Click_1(object sender, EventArgs e)
        {
            string city = txtCity.Text;  // نام شهری که کاربر وارد کرده است.
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();

                        // تبدیل داده‌های JSON به مدل
                        WeatherInfo weather = JsonConvert.DeserializeObject<WeatherInfo>(data);

                        // نمایش اطلاعات در Label
                        lblWeatherInfo.Text = $"City: {weather.Name}\n" +
                                              $"Temperature: {weather.Main.Temp}°C\n" +
                                              $"Humidity: {weather.Main.Humidity}%\n" +
                                              $"Weather: {weather.Weather[0].Description}";
                    }
                    else
                    {
                        lblWeatherInfo.Text = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                    }
                }
            }
            catch (Exception ex)
            {
                lblWeatherInfo.Text = $"An error occurred: {ex.Message}";
            }
        }
    }
}
