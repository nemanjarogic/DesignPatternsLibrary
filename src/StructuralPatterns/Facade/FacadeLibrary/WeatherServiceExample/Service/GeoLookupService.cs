namespace FacadeLibrary.WeatherServiceExample.Service;

public class GeoLookupService
{
    public Coordinates FindCoordinates(string zipCode) =>
        new()
        {
            Latitude = 43.676422,
            Longitude = -116.278025,
        };

    public string FindCity(string zipCode) => "Boise";

    public string FindState(string zipCode) => "Idaho";
}
