using System.Collections.Generic;
using System.Linq;
using CompositeLibrary.ShareholdersExample.After.Common;

namespace CompositeLibrary.ShareholdersExample.After
{
    public class Corporation : Shareholder
    {
        public List<Shareholder> Shareholders { get; set; } = new List<Shareholder>();

        public override int NumberOfShares
        {
            get
            {
                return Shareholders.Sum(shareholder => shareholder.NumberOfShares);
            }
            set
            {
                var sharesForEachShareholder = value / Shareholders.Count;
                var remainingShares = value % Shareholders.Count;

                foreach (var shareholder in Shareholders)
                {
                    shareholder.NumberOfShares = sharesForEachShareholder + remainingShares;
                    remainingShares = 0;
                }
            }
        }

        public override void PrintReport()
        {
            foreach (var shareholder in Shareholders)
            {
                shareholder.PrintReport();
            }
        }
    }
}
