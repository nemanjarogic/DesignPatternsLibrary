namespace FacadeLibrary.WeatherServiceExample.Service
{
    public class TemperatureConverter
    {
        public double ConvertFahrenheitToCelsius(double degrees)
        {
            return ((degrees - 32) / 9.0) * 5.0;
        }
    }
}
