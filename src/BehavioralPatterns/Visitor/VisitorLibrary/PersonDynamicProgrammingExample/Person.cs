using VisitorLibrary.PersonDynamicProgrammingExample.Elements.Common;
using VisitorLibrary.PersonDynamicProgrammingExample.Visitors.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample;

public class Person
{
    private readonly List<IAsset> _assets = new();

    public void RegisterNewAsset(IAsset asset) =>
        _assets.Add(asset);

    public void InspectAssets(AssetVisitor visitor) =>
        visitor.Visit(_assets);
    // It is possible to use this approach too.
    // foreach (var asset in Assets)
    // {
    //     visitor.DynamicVisit(asset);
    // }
}
