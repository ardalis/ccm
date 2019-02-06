using System.Collections.Generic;
using System.Linq;

namespace CCMEngine
{
    public static class MetricExtensions
    {
        public static int AggregateComplexity(this IEnumerable<ccMetric> metrics) => metrics.Sum(m => m.CCM / 10);
    }
}
