namespace StudyBuddy.Services;

public interface IWeatherService
{
    Weather GetWeatherByCity(string cityName);
}

public record Weather
{
    public string? City { get; set; }
    public string? Conditions { get; set; }
    public string? Temperature { get; set; }
}

