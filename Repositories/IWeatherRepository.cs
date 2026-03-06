using StudyBuddy.Services;

namespace StudyBuddy.Repositories;

public interface IWeatherRepository
{
    Weather GetWeatherData(string cityName);
}

