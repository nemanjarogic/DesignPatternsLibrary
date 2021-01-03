using System;

namespace AdapterLibrary.MovieBroadcasterExample
{
    public class ThirdPartyBroadcaster
    {
        public void Broadcast(string jsonMovies)
        {
            Console.WriteLine("\nNew movies are available for broadcasting from 3rd party system...");
            Console.WriteLine(jsonMovies);
        }
    }
}
