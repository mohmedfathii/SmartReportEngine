using SmartReportEngine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReportEngine.Application.Interfaces
{
    public interface ILabTestStrategy
    {
        string TestName { get; }

        void Analyze(LabTestResult result);
    }
}
