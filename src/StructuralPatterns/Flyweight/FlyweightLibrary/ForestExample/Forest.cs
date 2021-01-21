using System.Collections.Generic;
using System.Drawing;

namespace FlyweightLibrary.ForestExample
{
    public class Forest
    {
        private readonly TreeFactory _treeFactory;
        private readonly ICollection<Tree> _trees;

        public Forest(TreeFactory treeFactory)
        {
            _treeFactory = treeFactory;
            _trees = new List<Tree>();
        }

        public void PlantTree(string name, KnownColor color, string texture, double latitude, double longitude)
        {
            var treeType = _treeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(latitude, longitude, treeType);

            _trees.Add(tree);
        }

        public void Render()
        {
            foreach (var tree in _trees)
            {
                tree.Render();
            }
        }
    }
}
