using SmartReportEngine.Domain.Entities;
using SmartReportEngine.Domain.Enums;


namespace SmartReportEngine.Domain.Rules
{
    public class HighRule : ILabTestRule
    {
        public bool IsMatch(LabTestResult result)
        {
            return result.Value > result.MaxRange;
        }

        public void Apply(LabTestResult result)
        {
            result.SetResult(ResultStatus.High, "Above normal range");
        }
    }
}
