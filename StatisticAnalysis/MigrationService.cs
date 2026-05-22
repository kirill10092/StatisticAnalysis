using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace StatisticAnalysis
{
    public class MigrationService
    {
        public List<MigrationRecord> LoadFromCsv(string filePath)
        {
            var records = new List<MigrationRecord>();

            var lines = File.ReadAllLines(filePath);

            if (lines.Length < 2)
                throw new Exception("Файл пустой или не содержит данных.");

            var headers = lines[0].Split(';');

            if (headers.Length < 3 ||
                headers[0].ToLower() != "year" ||
                headers[1].ToLower() != "immigrants" ||
                headers[2].ToLower() != "emigrants")
            {
                throw new Exception(
                    "Файл должен содержать колонки: year;immigrants;emigrants");
            }

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                var parts = lines[i].Split(';');

                var record = new MigrationRecord
                {
                    Year = int.Parse(parts[0]),

                    Immigrants = double.Parse(
                        parts[1].Replace(',', '.'),
                        CultureInfo.InvariantCulture),

                    Emigrants = double.Parse(
                        parts[2].Replace(',', '.'),
                        CultureInfo.InvariantCulture)
                };

                records.Add(record);
            }

            return records.OrderBy(r => r.Year).ToList();
        }

        public string AnalyzeMaxPercentChange(
            List<MigrationRecord> records)
        {
            if (records == null || records.Count < 2)
                return "Недостаточно данных для анализа.";

            string result =
                "Максимальный процент изменения миграции за год:\r\n\r\n";

            result += AnalyzeIndicator(
                records,
                "Иммигранты",
                r => r.Immigrants);

            result += "\r\n";

            result += AnalyzeIndicator(
                records,
                "Эмигранты",
                r => r.Emigrants);

            return result;
        }

        private string AnalyzeIndicator(
            List<MigrationRecord> records,
            string name,
            Func<MigrationRecord, double> selector)
        {
            double maxPercentChange = 0;

            double absoluteChange = 0;

            int year = 0;

            for (int i = 1; i < records.Count; i++)
            {
                double previous = selector(records[i - 1]);

                double current = selector(records[i]);

                if (previous == 0)
                    continue;

                double change = current - previous;

                double percentChange =
                    change / previous * 100;

                if (Math.Abs(percentChange) >
                    Math.Abs(maxPercentChange))
                {
                    maxPercentChange = percentChange;

                    absoluteChange = change;

                    year = records[i].Year;
                }
            }

            return
    $"Показатель: {name}\r\n" +
    $"Год максимального изменения: {year}\r\n" +
    $"Процент изменения: {maxPercentChange:F2}%\r\n" +
    $"Абсолютное изменение: {absoluteChange:N0}\r\n";
        }
    }
}