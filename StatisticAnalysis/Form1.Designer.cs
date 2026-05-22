namespace StatisticAnalysis
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();

            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKirill = new System.Windows.Forms.TabPage();
            this.tabPageRoman = new System.Windows.Forms.TabPage();

            this.btnOpen = new System.Windows.Forms.Button();
            this.btnForecast = new System.Windows.Forms.Button();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.numPeriod = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxAnalysis = new System.Windows.Forms.TextBox();

            this.btnOpenRoman = new System.Windows.Forms.Button();
            this.btnForecastRoman = new System.Windows.Forms.Button();
            this.numYearsRoman = new System.Windows.Forms.NumericUpDown();
            this.numWindowRoman = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewRoman = new System.Windows.Forms.DataGridView();
            this.chartRoman = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxRoman = new System.Windows.Forms.TextBox();

            this.tabControl1.SuspendLayout();
            this.tabPageKirill.SuspendLayout();
            this.tabPageRoman.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.numYearsRoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowRoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoman)).BeginInit();

            this.SuspendLayout();

            // tabControl1
            this.tabControl1.Controls.Add(this.tabPageKirill);
            this.tabControl1.Controls.Add(this.tabPageRoman);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 650);
            this.tabControl1.TabIndex = 0;

            // tabPageKirill
            this.tabPageKirill.Controls.Add(this.textBoxAnalysis);
            this.tabPageKirill.Controls.Add(this.numPeriod);
            this.tabPageKirill.Controls.Add(this.numDays);
            this.tabPageKirill.Controls.Add(this.chart1);
            this.tabPageKirill.Controls.Add(this.dataGridView1);
            this.tabPageKirill.Controls.Add(this.btnForecast);
            this.tabPageKirill.Controls.Add(this.btnOpen);
            this.tabPageKirill.Location = new System.Drawing.Point(4, 25);
            this.tabPageKirill.Name = "tabPageKirill";
            this.tabPageKirill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKirill.Size = new System.Drawing.Size(1192, 621);
            this.tabPageKirill.TabIndex = 0;
            this.tabPageKirill.Text = "Вариант Кирилл";
            this.tabPageKirill.UseVisualStyleBackColor = true;

            // tabPageRoman
            this.tabPageRoman.Controls.Add(this.textBoxRoman);
            this.tabPageRoman.Controls.Add(this.numWindowRoman);
            this.tabPageRoman.Controls.Add(this.numYearsRoman);
            this.tabPageRoman.Controls.Add(this.chartRoman);
            this.tabPageRoman.Controls.Add(this.dataGridViewRoman);
            this.tabPageRoman.Controls.Add(this.btnForecastRoman);
            this.tabPageRoman.Controls.Add(this.btnOpenRoman);
            this.tabPageRoman.Location = new System.Drawing.Point(4, 25);
            this.tabPageRoman.Name = "tabPageRoman";
            this.tabPageRoman.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoman.Size = new System.Drawing.Size(1192, 621);
            this.tabPageRoman.TabIndex = 1;
            this.tabPageRoman.Text = "Вариант Роман";
            this.tabPageRoman.UseVisualStyleBackColor = true;

            // btnOpen
            this.btnOpen.Location = new System.Drawing.Point(22, 24);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть файл";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);

            // btnForecast
            this.btnForecast.Location = new System.Drawing.Point(22, 75);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(120, 40);
            this.btnForecast.TabIndex = 1;
            this.btnForecast.Text = "Построить прогноз";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);

            // numDays
            this.numDays.Location = new System.Drawing.Point(22, 130);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(90, 22);
            this.numDays.TabIndex = 2;

            // numPeriod
            this.numPeriod.Location = new System.Drawing.Point(130, 130);
            this.numPeriod.Name = "numPeriod";
            this.numPeriod.Size = new System.Drawing.Size(90, 22);
            this.numPeriod.TabIndex = 3;

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 250);
            this.dataGridView1.TabIndex = 4;

            // chart1
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(500, 24);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(650, 450);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";

            // textBoxAnalysis
            this.textBoxAnalysis.Location = new System.Drawing.Point(22, 440);
            this.textBoxAnalysis.Multiline = true;
            this.textBoxAnalysis.Name = "textBoxAnalysis";
            this.textBoxAnalysis.ReadOnly = true;
            this.textBoxAnalysis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnalysis.Size = new System.Drawing.Size(450, 120);
            this.textBoxAnalysis.TabIndex = 6;

            // btnOpenRoman
            this.btnOpenRoman.Location = new System.Drawing.Point(22, 24);
            this.btnOpenRoman.Name = "btnOpenRoman";
            this.btnOpenRoman.Size = new System.Drawing.Size(120, 40);
            this.btnOpenRoman.TabIndex = 0;
            this.btnOpenRoman.Text = "Открыть файл";
            this.btnOpenRoman.UseVisualStyleBackColor = true;
            this.btnOpenRoman.Click += new System.EventHandler(this.btnOpenRoman_Click);

            // btnForecastRoman
            this.btnForecastRoman.Location = new System.Drawing.Point(22, 75);
            this.btnForecastRoman.Name = "btnForecastRoman";
            this.btnForecastRoman.Size = new System.Drawing.Size(120, 40);
            this.btnForecastRoman.TabIndex = 1;
            this.btnForecastRoman.Text = "Построить прогноз";
            this.btnForecastRoman.UseVisualStyleBackColor = true;
            this.btnForecastRoman.Click += new System.EventHandler(this.btnForecastRoman_Click);

            // numYearsRoman
            this.numYearsRoman.Location = new System.Drawing.Point(22, 130);
            this.numYearsRoman.Name = "numYearsRoman";
            this.numYearsRoman.Size = new System.Drawing.Size(90, 22);
            this.numYearsRoman.TabIndex = 2;

            // numWindowRoman
            this.numWindowRoman.Location = new System.Drawing.Point(130, 130);
            this.numWindowRoman.Name = "numWindowRoman";
            this.numWindowRoman.Size = new System.Drawing.Size(90, 22);
            this.numWindowRoman.TabIndex = 3;

            // dataGridViewRoman
            this.dataGridViewRoman.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoman.Location = new System.Drawing.Point(22, 170);
            this.dataGridViewRoman.Name = "dataGridViewRoman";
            this.dataGridViewRoman.Size = new System.Drawing.Size(450, 250);
            this.dataGridViewRoman.TabIndex = 4;

            // chartRoman
            chartArea2.Name = "ChartArea1";
            this.chartRoman.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRoman.Legends.Add(legend2);
            this.chartRoman.Location = new System.Drawing.Point(500, 24);
            this.chartRoman.Name = "chartRoman";
            this.chartRoman.Size = new System.Drawing.Size(650, 450);
            this.chartRoman.TabIndex = 5;
            this.chartRoman.Text = "chartRoman";

            // textBoxRoman
            this.textBoxRoman.Location = new System.Drawing.Point(22, 440);
            this.textBoxRoman.Multiline = true;
            this.textBoxRoman.Name = "textBoxRoman";
            this.textBoxRoman.ReadOnly = true;
            this.textBoxRoman.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRoman.Size = new System.Drawing.Size(450, 120);
            this.textBoxRoman.TabIndex = 6;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Статистический анализ";

            this.tabControl1.ResumeLayout(false);
            this.tabPageKirill.ResumeLayout(false);
            this.tabPageKirill.PerformLayout();
            this.tabPageRoman.ResumeLayout(false);
            this.tabPageRoman.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.numYearsRoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowRoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoman)).EndInit();

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageKirill;
        private System.Windows.Forms.TabPage tabPageRoman;

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.NumericUpDown numPeriod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxAnalysis;

        private System.Windows.Forms.Button btnOpenRoman;
        private System.Windows.Forms.Button btnForecastRoman;
        private System.Windows.Forms.NumericUpDown numYearsRoman;
        private System.Windows.Forms.NumericUpDown numWindowRoman;
        private System.Windows.Forms.DataGridView dataGridViewRoman;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRoman;
        private System.Windows.Forms.TextBox textBoxRoman;
    }
}