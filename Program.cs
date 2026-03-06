using StudyBuddy.Repositories;
using StudyBuddy.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Services
builder.Services.AddSingleton<IWeatherService, WeatherService>();
builder.Services.AddScoped<IWeatherRepository, WeatherRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

// Original endpoint kept for reference
app.MapGet("/", () => "Hello World!");

app.Run();

