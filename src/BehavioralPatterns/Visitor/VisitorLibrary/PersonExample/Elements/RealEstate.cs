using VisitorLibrary.PersonExample.Elements.Common;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Elements
{
    public class RealEstate : IAsset
    {
        public int EstimatedValue { get; set; }

        public int MonthlyRent { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
