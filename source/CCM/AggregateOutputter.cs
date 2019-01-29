using CCMEngine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CCM
{
    public class AggregateOutputter : CCMOutputter
    {
        public override void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose)
        {
            int aggregateMetric = metrics.Sum(m => m.CCM / 10);
            Console.WriteLine(aggregateMetric);
        }
    }
}
