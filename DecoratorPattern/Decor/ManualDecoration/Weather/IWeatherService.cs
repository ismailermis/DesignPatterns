namespace ManualDecoration.Weather;

public interface IWeatherService
{
    Task<WeatherResponse?> GetWeatherForCityAsync(string city);
}
