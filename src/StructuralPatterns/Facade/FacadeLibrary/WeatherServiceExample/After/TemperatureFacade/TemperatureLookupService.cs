using FacadeLibrary.WeatherServiceExample.Service;

namespace FacadeLibrary.WeatherServiceExample.After.TemperatureFacade
{
    public class TemperatureLookupService
    {
        private readonly WeatherService _weatherService;
        private readonly GeoLookupService _geoLookupService;
        private readonly TemperatureConverter _temperatureConverter;

        public TemperatureLookupService()
            : this(new WeatherService(), new GeoLookupService(), new TemperatureConverter())
        {
        }

        public TemperatureLookupService(
            WeatherService weatherService,
            GeoLookupService geoLookupService,
            TemperatureConverter englishMetricConverter)
        {
            _weatherService = weatherService;
            _geoLookupService = geoLookupService;
            _temperatureConverter = englishMetricConverter;
        }

        public LocalTemperature GetTemperature(string zipCode)
        {
            var city = _geoLookupService.FindCity(zipCode);
            var state = _geoLookupService.FindState(zipCode);
            var coords = _geoLookupService.FindCoordinates(zipCode);

            var fahrenheitDegrees = _weatherService.GetTemperatureFahrenheit(coords.Latitude, coords.Longitude);
            var celsiusDegrees = _temperatureConverter.ConvertFahrenheitToCelsius(fahrenheitDegrees);

            return new LocalTemperature()
            {
                Fahrenheit = fahrenheitDegrees,
                Celsius = celsiusDegrees,
                City = city,
                State = state,
            };
        }
    }
}
