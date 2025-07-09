using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WeatherMaui.Models;
using WeatherMaui.Services;

namespace WeatherMaui.ViewModels
{
    public partial class WeatherViewModel : ObservableObject
    {
        private readonly WeatherService _weatherService = new();

        [ObservableProperty]
        private string? _city;

        [ObservableProperty]
        private WeatherForecast? _forecast;

        [RelayCommand]
        private async Task LoadWeather()
        {
            if (string.IsNullOrWhiteSpace(City))
                return;

            Forecast = await _weatherService.GetWeatherAsync(City);
        }
    }
}
