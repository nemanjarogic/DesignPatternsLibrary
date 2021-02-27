using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace AdapterLibrary.MovieBroadcasterExample
{
    /// <summary>
    /// There is no way to pass an xDocument from registry to the third party broadcaster,
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

            Console.WriteLine("Movies from internal registry...");
            Console.WriteLine(xmlMovies);

            IEnumerable<Movie> modelMovies = xmlMovies
                .Element("Movies")
                .Elements("Movie")
                .Select(movie => new Movie
                {
                    Name = movie.Attribute("Name").Value,
                    ReleaseDate = DateTime.Parse(movie.Attribute("ReleaseDate").Value),
                    Rating = Convert.ToDouble(movie.Attribute("Rating").Value),
                });

            string jsonMovies = JsonConvert.SerializeObject(modelMovies, Formatting.Indented);

            return jsonMovies;
        }
    }
}
