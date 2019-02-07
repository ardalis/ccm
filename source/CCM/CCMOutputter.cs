using CCMEngine;
using System.Collections.Generic;

namespace CCM
{
    public abstract class CCMOutputter
    {
        public static readonly string XmlOutputType = "XML";
        public static readonly string TextOutputType = "Text";
        public static readonly string TabbedOutputType = "Tabbed";
        public static readonly string CSVOutputType = "CSV";
        public static readonly string AggregateConsoleOutputType = "AggregateConsole";
        public static readonly string AggregateJSONFileOutputType = "AggregateJSONFile";
        public static readonly string AggregateTeamCityOutputType = "AggregateTeamCity";
        public static readonly string AggregateAzureDevOpsOutputType = "AggregateAzureDevOps";

        public abstract void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose);
    }
}
