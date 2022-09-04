using VisitorLibrary.PersonExample.Elements.Common;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample;

public class Person
{
    private readonly List<IAsset> _assets = new();

    public void RegisterNewAsset(IAsset asset) =>
        _assets.Add(asset);

    public void InspectAssets(IVisitor visitor)
    {
        foreach (var asset in _assets)
        {
            asset.Accept(visitor);
        }
    }
}
