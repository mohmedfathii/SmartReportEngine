using SmartReportEngine.Application.Interfaces;
using SmartReportEngine.Application.Services.Strategies;

namespace SmartReportEngine.Application.Services;

public class LabTestStrategyFactory
{
    private readonly List<ILabTestStrategy> _strategies;

    public LabTestStrategyFactory()
    {
        _strategies = new List<ILabTestStrategy>
        {
            new HemoglobinStrategy(),
            new GlucoseStrategy()
        };
    }

    public ILabTestStrategy GetStrategy(string testName)
    {
        return _strategies
            .FirstOrDefault(s => s.TestName == testName)
            ?? throw new Exception($"No strategy found for {testName}");
    }
}