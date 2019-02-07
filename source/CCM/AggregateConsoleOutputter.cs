using CCMEngine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CCM
{
    public class AggregateConsoleOutputter : CCMOutputter
    {
        public override void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose)
        {
            int aggregateComplexitySum = metrics.Sum(m => m.AggregateComplexity);
            Console.WriteLine(aggregateComplexitySum);
        }
    }
}
