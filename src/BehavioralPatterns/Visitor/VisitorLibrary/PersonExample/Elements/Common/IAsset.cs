using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Elements.Common
{
    public interface IAsset
    {
        void Accept(IVisitor visitor);
    }
}
