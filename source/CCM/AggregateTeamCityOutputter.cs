using CCMEngine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CCM
{
    public class AggregateTeamCityOutputter : CCMOutputter
    {
        public override void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose)
        {
            int aggregateComplexitySum = metrics.Sum(m => m.AggregateComplexity);
            Console.WriteLine($"##teamcity[buildStatisticValue key='Aggregate Complexity' value='{aggregateComplexitySum}']");
        }
    }
}
