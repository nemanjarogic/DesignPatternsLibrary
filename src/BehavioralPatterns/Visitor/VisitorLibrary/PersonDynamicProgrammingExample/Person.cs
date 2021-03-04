using System.Collections.Generic;
using VisitorLibrary.PersonDynamicProgrammingExample.Elements.Common;
using VisitorLibrary.PersonDynamicProgrammingExample.Visitors.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample
{
    public class Person
    {
        public List<IAsset> Assets { get; set; } = new List<IAsset>();

        public void InspectAssets(AssetVisitor visitor)
        {
            visitor.Visit(Assets);

            // It is possible to use this approach too.
            // foreach (var asset in Assets)
            // {
            //     visitor.DynamicVisit(asset);
            // }
        }
    }
}
