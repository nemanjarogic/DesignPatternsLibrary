using System.Collections.Generic;
using VisitorLibrary.PersonExample.Elements.Common;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample
{
    public class Person
    {
        public List<IAsset> Assets { get; set; } = new List<IAsset>();

        public void InspectAssets(IVisitor visitor)
        {
            foreach (var asset in Assets)
            {
                asset.Accept(visitor);
            }
        }
    }
}
