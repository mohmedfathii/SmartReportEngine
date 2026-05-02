using SmartReportEngine.Domain.Entities;


namespace SmartReportEngine.Domain.Rules
{
    public interface ILabTestRule
    {
        bool IsMatch(LabTestResult result);

        void Apply(LabTestResult result);
    }
}
