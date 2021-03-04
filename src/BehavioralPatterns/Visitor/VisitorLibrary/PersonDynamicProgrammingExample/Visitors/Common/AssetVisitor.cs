using System.Collections.Generic;
using VisitorLibrary.PersonDynamicProgrammingExample.Elements;
using VisitorLibrary.PersonDynamicProgrammingExample.Elements.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample.Visitors.Common
{
    public abstract class AssetVisitor
    {
        public void Visit(IEnumerable<IAsset> assets)
        {
            foreach (IAsset asset in assets)
            {
                DynamicVisit(asset);
            }
        }

        /// <summary>
        /// Performs a dynamic dispatch by calling the most specific version of Visit method
        /// as determined at runtime (there is no need for switches based on type).
        /// Depending on the use-case this we can restrict access modifiers as appropriate.
        /// </summary>
        /// <param name="asset">Asset.</param>
        public void DynamicVisit(IAsset asset)
        {
            Visit((dynamic)asset);
        }

        // Visit methods are defined as before, but they are no longer public.
        protected abstract void Visit(BankAccount bankAccount);

        protected abstract void Visit(Loan loan);

        protected abstract void Visit(RealEstate realEstate);
    }
}
