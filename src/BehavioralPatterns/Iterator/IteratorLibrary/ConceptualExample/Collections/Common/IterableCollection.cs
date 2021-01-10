using System.Collections;

namespace IteratorLibrary.ConceptualExample.Collections.Common
{
    public abstract class IterableCollection : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
