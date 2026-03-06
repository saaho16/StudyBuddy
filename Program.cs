var builder = WebApplication.CreateBuilder(args);

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger middleware
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.MapGet("/{cityName}/weather", GetWeatherByCity);

// Codespaces-friendly port binding
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Run($"http://0.0.0.0:{port}");

Weather GetWeatherByCity(string cityName)
{
    app.Logger.LogInformation($"Weather requested for {cityName}.");
    var weather = new Weather(cityName);
    return weather;
}

public record Weather
{
    public string City { get; set; }

    public Weather(string city)
    {
        City = city;
        Conditions = "Cloudy";
        Temperature = new Random().Next(0, 40).ToString();
    }

    public string Conditions { get; set; }
    public string Temperature { get; set; }
}