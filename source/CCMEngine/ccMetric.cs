using System;

namespace CCMEngine
{
    public class ccMetric
  {
    public string Filename { get; set; }
    public string Unit { get; set; }
    public int CCM { get; set; }
    public int AggregateComplexity
    {
        get
        {
            if (CCM < 0) throw new ArgumentOutOfRangeException(nameof(CCM), "Cyclomatic Complexity cannot be negative.");
            return CCM / 10;
        }
    }

      public object Custom { get; set; }
    public int StartLineNumber { get; set; }
    public int EndLineNumber { get; set; }

    public static string GetClassification(int ccm)
    {
      if (ccm >= 51)
        return "untestable, very high risk";
      if (ccm >= 21)
        return "complex, high risk";
      else if (ccm >= 11)
        return "more complex, moderate risk";
      else
        return "simple, without much risk";
    }

    public ccMetric(string filename, string unit, int ccm)
    {
      this.Filename = filename;
      this.Unit = unit;
      this.CCM = ccm;
    }

    public ccMetric(string filename, string unit, int ccm, object custom)
    {
      this.Filename = filename;
      this.Unit = unit;
      this.CCM = ccm;
      this.Custom = custom;
    }

    public string Classification
    {
      get
      {
        return GetClassification(this.CCM);
      }
    }

  }
}
