using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecorateSample.Weather
{
    public interface IWeatherService
    {
        Task<WeatherResponse?> GetWeatherForCityAsync(string city);
    }
}