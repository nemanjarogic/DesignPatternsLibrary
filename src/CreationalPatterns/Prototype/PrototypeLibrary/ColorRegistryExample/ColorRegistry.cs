using System.Collections.Generic;
using PrototypeLibrary.ColorRegistryExample.Common;

namespace PrototypeLibrary.ColorRegistryExample
{
    public class ColorRegistry
    {
        private Dictionary<string, IColorPrototype> _colors = new Dictionary<string, IColorPrototype>();

        public IColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors[key] = value; }
        }
    }
}
