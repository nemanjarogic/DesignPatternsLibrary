namespace FlyweightLibrary.ForestExample
{
    public class Tree
    {
        private readonly double _latitude;
        private readonly double _longitude;
        private readonly TreeType _treeType;

        public Tree(double latitude, double longitude, TreeType treeType)
        {
            _latitude = latitude;
            _longitude = longitude;
            _treeType = treeType;
        }

        public void Render()
        {
            _treeType.Render(_latitude, _longitude);
        }
    }
}
