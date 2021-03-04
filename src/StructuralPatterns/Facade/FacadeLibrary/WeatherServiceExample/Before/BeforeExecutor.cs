using System;
using BuildingBlocks;
using FacadeLibrary.WeatherServiceExample.Service;

namespace FacadeLibrary.WeatherServiceExample.Before
{
    public static class BeforeExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Weather service example - before");

            var zipCode = "83714";
            var geoLookupService = new GeoLookupService();

            var city = geoLookupService.FindCity(zipCode);
            var state = geoLookupService.FindState(zipCode);
            var coords = geoLookupService.FindCoordinates(zipCode);

            var weatherService = new WeatherService();
            var fahrenheitDegrees = weatherService.GetTemperatureFahrenheit(coords.Latitude, coords.Longitude);

            var temperatureConverter = new TemperatureConverter();
            var celsiusDegrees = temperatureConverter.ConvertFahrenheitToCelsius(fahrenheitDegrees);

            Console.WriteLine(
                "The current temperature is {0}F/{1}C in {2}, {3}",
                fahrenheitDegrees.ToString("F1"),
                celsiusDegrees.ToString("F1"),
                city,
                state);
        }
    }
}
