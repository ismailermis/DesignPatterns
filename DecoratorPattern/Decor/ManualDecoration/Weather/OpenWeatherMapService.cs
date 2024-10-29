using System.Net;
using System.Text.Json.Serialization;

namespace ManualDecoration.Weather;

public class OpenWeatherMapService : IWeatherService
{
    private const string ApiKey = "2a044727b97a92cc75ca6258d62c2e3b";

    private readonly IHttpClientFactory _httpClientFactory;

    public OpenWeatherMapService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<WeatherResponse?> GetWeatherForCityAsync(string city)
    {
        var client = _httpClientFactory.CreateClient();

        var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";

        var weatherResponse = await client.GetAsync(url);
        if (weatherResponse.StatusCode == HttpStatusCode.NotFound)
        {
            return null;
        }

        var weather = await weatherResponse.Content.ReadFromJsonAsync<OpenWeatherMapWeatherResponse>();
        
        return new WeatherResponse
        {
            Temperature = weather!.Weather.Temp,
            FeelsLike = weather.Weather.FeelsLike
        };
    }

    private class OpenWeatherMapWeatherResponse
    {
        [JsonPropertyName("main")] public OpenWeatherMapWeather Weather { get; set; }

        [JsonPropertyName("visibility")] public int Visibility { get; set; }

        [JsonPropertyName("dt")] public int Dt { get; set; }

        [JsonPropertyName("timezone")] public int Timezone { get; set; }

        [JsonPropertyName("id")] public int Id { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("cod")] public int Cod { get; set; }
    }

    private class OpenWeatherMapWeather
    {
        [JsonPropertyName("temp")] public double Temp { get; set; }

        [JsonPropertyName("feels_like")] public double FeelsLike { get; set; }

        [JsonPropertyName("temp_min")] public double TempMin { get; set; }

        [JsonPropertyName("temp_max")] public double TempMax { get; set; }

        [JsonPropertyName("pressure")] public int Pressure { get; set; }

        [JsonPropertyName("humidity")] public int Humidity { get; set; }
    }
}
