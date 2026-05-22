using System.Collections.Generic;

namespace StatisticAnalysis
{
    public class BadRoadRecord
    {
        public string Region { get; set; }

        public Dictionary<int, double> YearValues { get; set; } = new Dictionary<int, double>();
    }
}