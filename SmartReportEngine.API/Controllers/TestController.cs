using Microsoft.AspNetCore.Mvc;
using SmartReportEngine.Application.Services;
using SmartReportEngine.Domain.Entities;

namespace SmartReportEngine.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var test = new LabTestResult
        {
            TestName = "Hemoglobin",
            Value = 8,
            MinRange = 12,
            MaxRange = 16
        };

        var analyzer = new LabTestAnalyzer();
        analyzer.Analyze(test);

        return Ok(new
        {
            test.TestName,
            test.Value,
            test.Status,
            test.Interpretation
        });
    }
}