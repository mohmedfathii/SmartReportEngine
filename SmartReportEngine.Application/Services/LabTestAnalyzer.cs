using SmartReportEngine.Domain.Entities;
using SmartReportEngine.Domain.Rules;

namespace SmartReportEngine.Application.Services
{
    public class LabTestAnalyzer
    {
        private readonly List<ILabTestRule> _rules;

        public LabTestAnalyzer()
        {
            _rules = new List<ILabTestRule>
        {
            new LowRule(),
            new HighRule(),
            new NormalRule()
        };
        }

        public void Analyze(LabTestResult result)
        {
            var rule = _rules.FirstOrDefault(r => r.IsMatch(result));

            rule?.Apply(result);
        }
    }
}
