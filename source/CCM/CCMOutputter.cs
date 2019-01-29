using CCMEngine;
using System.Collections.Generic;

namespace CCM
{
    public abstract class CCMOutputter
  {
    public static string XmlOutputType = "XML";
    public static string TextOutputType = "Text";
    public static string TabbedOutputType = "Tabbed";
    public static string CSVOutputType = "CSV";
    public static string AggregateOutputType = "Aggregate";

    public abstract void Output(List<ccMetric> metrics, List<ErrorInfo> errors, bool verbose);
  }
}
