namespace FacadeLibrary.WeatherServiceExample.Service;

public class TemperatureConverter
{
    public double ConvertFahrenheitToCelsius(double degrees) => (degrees - 32) / 9.0 * 5.0;
}
