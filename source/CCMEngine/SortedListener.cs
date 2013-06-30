﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CCMEngine
{
  public class SortedListener : ICCMNotify
  {
    List<ccMetric> metrics = new List<ccMetric>();
    List<string> ignoreUnits = null;
    object synchLock = new object();
    int numMetrics = 0;

    public SortedListener(int numMetrics, List<string> ignores)
    {
      this.numMetrics = numMetrics;
      this.ignoreUnits = ignores;
    }

    public List<ccMetric> Metrics
    {
      get
      {
        return this.metrics;
      }
    }

    private bool ShouldFilter(string unit)
    {
      string lowerUnit = unit.ToLower();

      foreach (string s in this.ignoreUnits)
      {
        if (lowerUnit.Contains(s.ToLower()))
          return true;
      }

      return false;
    }
    public void OnMetric(ccMetric metric, object context)
    {
      lock (this.synchLock)
      {
        if (!ShouldFilter(metric.Unit))
        {
          bool inserted = false;

          for (int i = 0; i < this.metrics.Count; ++i)
          {
            if (metric.CCM > this.metrics[i].CCM)
            {
              this.metrics.Insert(i, metric);
              inserted = true;
              break;
            }
          }

          if (!inserted)
            this.metrics.Add(metric);

          if (this.metrics.Count > this.numMetrics)
            this.metrics.RemoveAt(this.numMetrics);
        }
      }
    }

    public void Clear()
    {
      this.metrics.Clear();
    }
  }
}
