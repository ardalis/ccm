using CCMEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CCM
{
    public class AggregateJSONFileOutputter : CCMOutputter
    {
        public override void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose)
        {
            int aggregateComplexitySum = metrics.Sum(m => m.AggregateComplexity);
            File.WriteAllText("complexity.json", $@"{{
  ""aggregateComplexity"":{aggregateComplexitySum}
}}");
        }
    }
}
