using System.Net.Http;
using System.Text.Json;

// Ensure the partial class is correctly defined and InitializeComponent is accessible.  
public partial class WeatherPage : ContentPage
{
    public WeatherPage()
    {
        // Fix for CS0103: Ensure InitializeComponent is defined in the generated partial class.  
        InitializeComponent();
    }
}

public class WeatherResponse
{
    public WeatherMain Main { get; set; }
    public List<WeatherDescription> Weather { get; set; }
}

public class WeatherMain
{
    public double Temp { get; set; }
}

public class WeatherDescription
{
    public string Description { get; set; }
}
