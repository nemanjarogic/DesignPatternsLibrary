using VisitorLibrary.CompanyExample.Visitors.Common;

namespace VisitorLibrary.CompanyExample.Elements.Common
{
    public interface IEmployeeEvaluation
    {
        void Evaluate(IPerformanceReview performanceReview);
    }
}
