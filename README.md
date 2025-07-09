#Weather App (.NET MAUI)

Prosta aplikacja pogodowa w .NET MAUI z architekturą MVVM i pobieraniem danych z OpenWeatherMap.

##Funkcje
- Pobieranie bieżących danych pogodowych na podstawie miasta
- Wyświetlanie temperatury i opisu pogody
- Historia wyszukiwań miast

##Technologie
- .NET MAUI
- C#
- MVVM Toolkit
- REST API (OpenWeatherMap)

##Klucz API
Do działania potrzebujesz klucza API z [OpenWeatherMap](https://openweathermap.org/api).
Podmień `YOUR_API_KEY` w `WeatherViewModel.cs` na własny klucz:

```csharp
private const string ApiKey = \"YOUR_API_KEY\";
