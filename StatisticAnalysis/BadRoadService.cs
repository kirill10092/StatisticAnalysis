using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace StatisticAnalysis
{
    public class BadRoadService
    {
        public List<BadRoadRecord> LoadFromCsv(string filePath)
        {
            var records = new List<BadRoadRecord>();
            var lines = File.ReadAllLines(filePath);

            if (lines.Length < 2)
                throw new Exception("Файл пустой или не содержит данных.");

            var headers = lines[0].Split(';');

            if (headers.Length < 2 || headers[0].ToLower() != "region")
                throw new Exception("Первая колонка должна быть region.");

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                var parts = lines[i].Split(';');

                var record = new BadRoadRecord
                {
                    Region = parts[0]
                };

                for (int j = 1; j < headers.Length; j++)
                {
                    int year = int.Parse(headers[j]);

                    double value = double.Parse(
                        parts[j].Replace(',', '.'),
                        CultureInfo.InvariantCulture
                    );

                    record.YearValues[year] = value;
                }

                records.Add(record);
            }

            return records;
        }

        public string AnalyzeDecrease(List<BadRoadRecord> records)
        {
            if (records == null || records.Count == 0)
                return "Нет данных для анализа.";

            string maxRegion = "";
            string minRegion = "";

            double maxDecrease = double.MinValue;
            double minDecrease = double.MaxValue;

            foreach (var record in records)
            {
                var ordered = record.YearValues.OrderBy(x => x.Key).ToList();

                double firstValue = ordered.First().Value;
                double lastValue = ordered.Last().Value;

                double decrease = firstValue - lastValue;

                if (decrease > maxDecrease)
                {
                    maxDecrease = decrease;
                    maxRegion = record.Region;
                }

                if (decrease < minDecrease)
                {
                    minDecrease = decrease;
                    minRegion = record.Region;
                }
            }

            return
                $"Анализ доли плохих дорог за 15 лет:\n" +
                $"Максимально уменьшилась доля плохих дорог: {maxRegion} на {maxDecrease:F2}%\n" +
                $"Минимально уменьшилась доля плохих дорог: {minRegion} на {minDecrease:F2}%";
        }
    }
}