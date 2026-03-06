using StudyBuddy.Services;

namespace StudyBuddy.Repositories;

public class WeatherRepository : IWeatherRepository
{
    private readonly IWeatherService _weatherService;

    public WeatherRepository(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public Weather GetWeatherData(string cityName)
    {
        // Delegate to service layer - in a real app, this would fetch from database/API
        return _weatherService.GetWeatherByCity(cityName);
    }
}

