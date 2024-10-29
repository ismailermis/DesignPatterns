using ManualDecoration;
using ManualDecoration.Weather;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

// builder.Services.AddKeyedSingleton<IWeatherService, OpenWeatherMapService>("og");
// builder.Services.AddSingleton<IWeatherService, ResilientWeatherService>();

builder.Services.AddDecoratedSingleton<IWeatherService, ResilientWeatherService, OpenWeatherMapService>("og");

// builder.Services.AddSingleton<OpenWeatherMapService>();
// builder.Services.AddSingleton<IWeatherService>(x =>
//     new ResilientWeatherService(x.GetRequiredService<OpenWeatherMapService>()));

//builder.Services.AddSingleton<IWeatherService, OpenWeatherMapService>();

var app = builder.Build();

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
