namespace FacadeLibrary.WeatherServiceExample.Service
{
    public class GeoLookupService
    {
        public Coordinates FindCoordinates(string zipCode)
        {
            return new Coordinates()
            {
                Latitude = 43.676422,
                Longitude = -116.278025,
            };
        }

        public string FindCity(string zipCode)
        {
            return "Boise";
        }

        public string FindState(string zipCode)
        {
            return "Idaho";
        }
    }
}
