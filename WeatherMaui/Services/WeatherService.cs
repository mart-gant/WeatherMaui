using Newtonsoft.Json.Linq;
using WeatherMaui.Models;

namespace WeatherMaui.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient = new();

        public async Task<WeatherForecast> GetWeatherAsync(string city)
        {
            string apiKey = "YOUR_API_KEY"; // wpisz swój klucz
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=pl";

            var response = await _httpClient.GetStringAsync(url);
            var json = JObject.Parse(response);

            return new WeatherForecast
            {
                Description = json["weather"][0]["description"].ToString(),
                Temperature = (double)json["main"]["temp"]
            };
        }
    }
}
