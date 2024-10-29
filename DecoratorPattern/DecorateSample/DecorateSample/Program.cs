/*
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();
*/


using DecorateSample;
using DecorateSample.Weather;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

// builder.Services.AddKeyedSingleton<IWeatherService, OpenWeatherMapService>("og");
// builder.Services.AddSingleton<IWeatherService, ResilientWeatherService>();
// Keyed Service | Dependency Injection ve Extention Service
builder.Services.AddDecoratedSingelton<IWeatherService, ResilientWeatherService, OpenWeatherMapService>("og");

// Keyed Service olmadan Decorated servis ekleme 
// builder.Services.AddSingleton<OpenWeatherMapService>();
//  builder.Services.AddSingleton<IWeatherService>(x =>
//    new ResilientWeatherService(x.GetRequiredService<OpenWeatherMapService>()));
//
//builder.Services.AddSingleton<IWeatherService, OpenWeatherMapService>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/weather", async (
        string city,
        IWeatherService weatherService
    ) =>
    {
        var weather = await weatherService.GetWeatherForCityAsync(city);
        return weather is null ? Results.NotFound() : Results.Ok(weather);
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();




record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
