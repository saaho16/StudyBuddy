namespace StudyBuddy.Services;

public class WeatherService : IWeatherService
{
    private readonly ILogger<WeatherService> _logger;

    public WeatherService(ILogger<WeatherService> logger)
    {
        _logger = logger;
    }

    public Weather GetWeatherByCity(string cityName)
    {
        _logger.LogInformation($"Weather requested for {cityName}.");
        
        return new Weather
        {
            City = cityName,
            Conditions = "Cloudy",
            Temperature = new Random().Next(0, 40).ToString()
        };
    }
}

