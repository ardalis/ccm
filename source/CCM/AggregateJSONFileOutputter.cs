using CCMEngine;
using System.Collections.Generic;
using System.IO;

namespace CCM
{
    public class AggregateJSONFileOutputter : CCMOutputter
    {
        public override void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose)
        {
            File.WriteAllText("complexity.json", $@"{{
  ""aggregateComplexity"":{metrics.AggregateComplexity()}
}}");
        }
    }
}
