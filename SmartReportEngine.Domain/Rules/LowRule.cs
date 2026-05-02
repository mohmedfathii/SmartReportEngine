using SmartReportEngine.Domain.Entities;
using SmartReportEngine.Domain.Enums;


namespace SmartReportEngine.Domain.Rules
{
    public class LowRule : ILabTestRule
    {
        public bool IsMatch(LabTestResult result)
        {
            return result.Value < result.MinRange;
        }

        public void Apply(LabTestResult result)
        {
            result.SetResult(ResultStatus.Low, "Below normal range");
        }
    }
}
