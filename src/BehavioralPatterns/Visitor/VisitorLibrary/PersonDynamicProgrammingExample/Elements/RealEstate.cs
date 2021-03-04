using VisitorLibrary.PersonDynamicProgrammingExample.Elements.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample.Elements
{
    public class RealEstate : IAsset
    {
        public int EstimatedValue { get; set; }

        public int MonthlyRent { get; set; }
    }
}
