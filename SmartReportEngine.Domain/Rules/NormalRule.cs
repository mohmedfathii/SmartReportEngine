using SmartReportEngine.Domain.Entities;
using SmartReportEngine.Domain.Enums;

namespace SmartReportEngine.Domain.Rules
{
    public class NormalRule : ILabTestRule
    {
        public bool IsMatch(LabTestResult result)
        {
            return result.Value >= result.MinRange && result.Value <= result.MaxRange;
        }

        public void Apply(LabTestResult result)
        {
            result.SetResult(ResultStatus.Normal, "Within normal range");
        }
    }
}
