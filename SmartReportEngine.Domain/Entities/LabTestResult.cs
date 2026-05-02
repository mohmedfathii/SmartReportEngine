using SmartReportEngine.Domain.Enums;


namespace SmartReportEngine.Domain.Entities
{
    public class LabTestResult
    {
        public string TestName { get; set; } = string.Empty;

        public double Value { get; set; }

        public double MinRange { get; set; }

        public double MaxRange { get; set; }

        public ResultStatus Status { get; private set; }

        public string Interpretation { get; private set; } = string.Empty;

        public void SetResult(ResultStatus status, string interpretation)
        {
            Status = status;
            Interpretation = interpretation;
        }
    }
}
