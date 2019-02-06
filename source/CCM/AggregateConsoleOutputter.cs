using CCMEngine;
using System;
using System.Collections.Generic;

namespace CCM
{
    public class AggregateConsoleOutputter : CCMOutputter
    {
        public override void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose)
        {
            Console.WriteLine(metrics.AggregateComplexity());
        }
    }
}
