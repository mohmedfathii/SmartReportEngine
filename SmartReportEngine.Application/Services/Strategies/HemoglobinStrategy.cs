using SmartReportEngine.Application.Interfaces;
using SmartReportEngine.Domain.Entities;
using SmartReportEngine.Domain.Enums;

namespace SmartReportEngine.Application.Services.Strategies;

public class HemoglobinStrategy : ILabTestStrategy
{
    public string TestName => "Hemoglobin";

    public void Analyze(LabTestResult result)
    {
        // Status
        if (result.Value < result.MinRange)
        {
            result.SetResult(ResultStatus.Low, GetLowInterpretation(result));
        }
        else if (result.Value > result.MaxRange)
        {
            result.SetResult(ResultStatus.High, "High Hemoglobin - ممكن dehydration أو مشاكل تانية");
        }
        else
        {
            result.SetResult(ResultStatus.Normal, "Hemoglobin طبيعي");
        }
    }

    private string GetLowInterpretation(LabTestResult result)
    {
        if (result.Value < 8)
            return "Severe anemia - محتاج تدخل سريع";

        return "Possible Iron Deficiency Anemia";
    }
}