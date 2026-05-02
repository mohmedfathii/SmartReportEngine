using SmartReportEngine.Application.Interfaces;
using SmartReportEngine.Domain.Entities;
using SmartReportEngine.Domain.Enums;

namespace SmartReportEngine.Application.Services.Strategies;

public class GlucoseStrategy : ILabTestStrategy
{
    public string TestName => "Glucose";

    public void Analyze(LabTestResult result)
    {
        if (result.Value < 70)
        {
            result.SetResult(ResultStatus.Low, "Hypoglycemia - سكر منخفض");
        }
        else if (result.Value > 180)
        {
            result.SetResult(ResultStatus.High, GetHighInterpretation(result));
        }
        else
        {
            result.SetResult(ResultStatus.Normal, "سكر طبيعي");
        }
    }

    private string GetHighInterpretation(LabTestResult result)
    {
        if (result.Value > 250)
            return "Severe Hyperglycemia - خطر";

        return "Possible Diabetes";
    }
}