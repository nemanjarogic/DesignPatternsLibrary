using System.Xml.Linq;
using Newtonsoft.Json;

namespace AdapterLibrary.MovieBroadcasterExample;

/// <summary>
/// There is no way to pass an xDocument from the registry to the third party broadcaster,
/// so we need to create the adapter, which will make these two parties work together.
/// </summary>
public class BroadcastAdapter : IBroadcaster
{
    private readonly MovieRegistry _movieRegistry;
    private readonly ThirdPartyBroadcaster _thirdPartyBroadcaster;

    public BroadcastAdapter(MovieRegistry movieRegistry)
    {
        _movieRegistry = movieRegistry;
        _thirdPartyBroadcaster = new ThirdPartyBroadcaster();
    }

    public void BroadcastToExternalPartners()
    {
        string jsonMovies = ConvertRegistryMoviesToJson();
        _thirdPartyBroadcaster.Broadcast(jsonMovies);
    }

    private string ConvertRegistryMoviesToJson()
    {
        XDocument xmlMovies = _movieRegistry.GetAll();
        Console.WriteLine("Movies from the internal registry...");
        Console.WriteLine(xmlMovies);

        IEnumerable<Movie> modelMovies = xmlMovies
            .Element("Movies")!
            .Elements("Movie")
            .Select(movie => new Movie
            {
                Name = movie.Attribute(nameof(Movie.Name))!.Value,
                ReleaseDate = DateTime.Parse(movie.Attribute(nameof(Movie.ReleaseDate))!.Value),
                Rating = Convert.ToDouble(movie.Attribute(nameof(Movie.Rating))!.Value),
            });

        string jsonMovies = JsonConvert.SerializeObject(modelMovies, Formatting.Indented);
        Console.WriteLine("\nMovies from the internal registry are converted to JSON format");
        Console.WriteLine(jsonMovies);

        return jsonMovies;
    }
}
