using System;
using System.Collections.Generic;
using System.Linq;
using CCMEngine;

namespace CCM
{
    public class AggregateAzureDevOpsOutputter : CCMOutputter
    {
        public override void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose)
        {
            int aggregateComplexitySum = metrics.Sum(m => m.AggregateComplexity);
            Console.WriteLine($"##vso[build.addbuildtag]\"My Custom Metric:{aggregateComplexitySum}\"");
        }
    }
}