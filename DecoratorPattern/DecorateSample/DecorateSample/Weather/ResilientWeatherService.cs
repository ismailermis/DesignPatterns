using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecorateSample.Weather
{
public class ResilientWeatherService : IWeatherService
{
    private readonly IWeatherService _weatherService;

    public ResilientWeatherService(
        [FromKeyedServices("og")]IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public async Task<WeatherResponse?> GetWeatherForCityAsync(string city)
    {
        var retryCount = 0;
        Start:
        try
        {
            return await _weatherService.GetWeatherForCityAsync(city);
        }
        catch (Exception)
        {
            if (retryCount <= 4)
            {
                retryCount++;
                goto Start;
            }

            throw;
        }
    }
}
}