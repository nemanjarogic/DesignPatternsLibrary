using VisitorLibrary.PersonDynamicProgrammingExample.Elements.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample.Elements
{
    public class Loan : IAsset
    {
        public int Owed { get; set; }

        public int MonthlyPayment { get; set; }
    }
}
