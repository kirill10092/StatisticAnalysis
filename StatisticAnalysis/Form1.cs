using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StatisticAnalysis
{
    public partial class Form1 : Form
    {
        private List<BadRoadRecord> records = new List<BadRoadRecord>();
        private BadRoadService service = new BadRoadService();
        private MovingAverageForecaster forecaster = new MovingAverageForecaster();

        public Form1()
        {
            InitializeComponent();

            numDays.Minimum = 1;
            numDays.Maximum = 10;
            numDays.Value = 5;

            numPeriod.Minimum = 2;
            numPeriod.Maximum = 15;
            numPeriod.Value = 3;

            textBoxAnalysis.Text = "";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                records = service.LoadFromCsv(dialog.FileName);

                dataGridView1.DataSource = CreateTable(records);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DrawChart(records);

                textBoxAnalysis.Text = service.AnalyzeDecrease(records);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка чтения файла");
            }
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            if (records == null || records.Count == 0)
            {
                MessageBox.Show("Сначала откройте CSV-файл.");
                return;
            }

            int forecastCount = (int)numDays.Value;
            int window = (int)numPeriod.Value;

            if (window > records[0].YearValues.Count)
            {
                MessageBox.Show("Период скользящей средней больше количества лет.");
                return;
            }

            DrawChart(records);
            DrawForecast(records, window, forecastCount);
        }

        private DataTable CreateTable(List<BadRoadRecord> records)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Субъект");

            var years = records.First().YearValues.Keys.OrderBy(y => y).ToList();

            foreach (int year in years)
                table.Columns.Add(year.ToString());

            foreach (BadRoadRecord record in records)
            {
                DataRow row = table.NewRow();
                row["Субъект"] = record.Region;

                foreach (int year in years)
                    row[year.ToString()] = record.YearValues[year];

                table.Rows.Add(row);
            }

            return table;
        }

        private void DrawChart(List<BadRoadRecord> records)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            ChartArea area = new ChartArea("Main");
            area.AxisX.Title = "Год";
            area.AxisY.Title = "Доля плохих дорог, %";
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chart1.ChartAreas.Add(area);

            Legend legend = new Legend("Legend");
            legend.Docking = Docking.Right;
            chart1.Legends.Add(legend); 

            foreach (BadRoadRecord record in records)
            {
                Series series = new Series(record.Region);
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 2;
                series.MarkerStyle = MarkerStyle.Circle;
                series.MarkerSize = 6;

                foreach (var item in record.YearValues.OrderBy(x => x.Key))
                    series.Points.AddXY(item.Key, item.Value);

                chart1.Series.Add(series);
            }
        }

        private void DrawForecast(List<BadRoadRecord> records, int window, int forecastCount)
        {
            foreach (BadRoadRecord record in records)
            {
                var ordered = record.YearValues.OrderBy(x => x.Key).ToList();

                List<int> years = ordered.Select(x => x.Key).ToList();
                List<double> values = ordered.Select(x => x.Value).ToList();

                List<double> forecastValues = forecaster.Forecast(values, window, forecastCount);

                Series forecastSeries = new Series(record.Region + " прогноз");
                forecastSeries.ChartType = SeriesChartType.Line;
                forecastSeries.BorderDashStyle = ChartDashStyle.Dash;
                forecastSeries.BorderWidth = 3;

                int lastYear = years.Last();

                for (int i = values.Count; i < forecastValues.Count; i++)
                {
                    int forecastYear = lastYear + (i - values.Count + 1);
                    forecastSeries.Points.AddXY(forecastYear, forecastValues[i]);
                }

                chart1.Series.Add(forecastSeries);
            }
        }
    }
}