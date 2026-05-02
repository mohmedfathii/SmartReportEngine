using Microsoft.AspNetCore.Mvc;
using SmartReportEngine.Application.Services;
using SmartReportEngine.Domain.Entities;

namespace SmartReportEngine.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(string testName = "Hemoglobin", double value = 8)
    {
        var test = new LabTestResult
        {
            TestName = testName,
            Value = value,
            MinRange = 12,
            MaxRange = 16
        };

        var factory = new LabTestStrategyFactory();
        var strategy = factory.GetStrategy(test.TestName);

        strategy.Analyze(test);

        return Ok(new
        {
            test.TestName,
            test.Value,
            test.Status,
            test.Interpretation
        });
    }
}