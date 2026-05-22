using System.Collections.Generic;
using System.Linq;

namespace StatisticAnalysis
{
    public class MovingAverageForecaster
    {
        public List<double> Forecast(
            List<double> values,
            int movingAverageWindow,
            int forecastCount)
        {
            List<double> result = new List<double>(values);

            for (int i = 0; i < forecastCount; i++)
            {
                double average = result
                    .Skip(result.Count - movingAverageWindow)
                    .Take(movingAverageWindow)
                    .Average();

                result.Add(average);
            }

            return result;
        }
    }
}