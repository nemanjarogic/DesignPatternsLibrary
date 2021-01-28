using VisitorLibrary.CompanyExample.Elements.Common;

namespace VisitorLibrary.CompanyExample.Visitors.Common
{
    public interface IPerformanceReview
    {
        void Appraise(IEmployeeEvaluation employeeEvaluation);
    }
}
