using Microsoft.AspNetCore.Mvc;
using StudyBuddy.Services;

namespace StudyBuddy.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;
    private readonly ILogger<WeatherController> _logger;

    public WeatherController(IWeatherService weatherService, ILogger<WeatherController> logger)
    {
        _weatherService = weatherService;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Weather API is running");
    }

    [HttpGet("{cityName}")]
    public IActionResult GetWeatherByCity(string cityName)
    {
        _logger.LogInformation($"Weather requested for {cityName}.");
        
        var weather = _weatherService.GetWeatherByCity(cityName);
        return Ok(weather);
    }
}

