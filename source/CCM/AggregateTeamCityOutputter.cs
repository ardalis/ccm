using CCMEngine;
using System;
using System.Collections.Generic;

namespace CCM
{
    public class AggregateTeamCityOutputter : CCMOutputter
    {
        public override void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose)
        {
            Console.WriteLine($"##teamcity[buildStatisticValue key='Aggregate Complexity' value='{metrics.AggregateComplexity()}']");
        }
    }
}
