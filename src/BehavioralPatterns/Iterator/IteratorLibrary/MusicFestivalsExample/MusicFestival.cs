namespace IteratorLibrary.MusicFestivalsExample
{
    public class MusicFestival
    {
        public MusicFestival(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public string Name { get; set; }

        public string Country { get; set; }
    }
}
