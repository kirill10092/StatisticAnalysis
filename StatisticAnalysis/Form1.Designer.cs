namespace StatisticAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKirill = new System.Windows.Forms.TabPage();
            this.tabPageRoman = new System.Windows.Forms.TabPage();

            this.btnOpen = new System.Windows.Forms.Button();
            this.btnForecast = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.numPeriod = new System.Windows.Forms.NumericUpDown();
            this.labelResult = new System.Windows.Forms.Label();

            this.tabControl1.SuspendLayout();
            this.tabPageKirill.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).BeginInit();

            this.SuspendLayout();

            // tabControl1
            this.tabControl1.Controls.Add(this.tabPageKirill);
            this.tabControl1.Controls.Add(this.tabPageRoman);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 600);
            this.tabControl1.TabIndex = 0;

            // tabPageKirill
            this.tabPageKirill.Controls.Add(this.labelResult);
            this.tabPageKirill.Controls.Add(this.numPeriod);
            this.tabPageKirill.Controls.Add(this.numDays);
            this.tabPageKirill.Controls.Add(this.chart1);
            this.tabPageKirill.Controls.Add(this.dataGridView1);
            this.tabPageKirill.Controls.Add(this.btnForecast);
            this.tabPageKirill.Controls.Add(this.btnOpen);

            this.tabPageKirill.Location = new System.Drawing.Point(4, 25);
            this.tabPageKirill.Name = "tabPageKirill";
            this.tabPageKirill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKirill.Size = new System.Drawing.Size(992, 571);
            this.tabPageKirill.TabIndex = 0;
            this.tabPageKirill.Text = "Вариант Кирилл";
            this.tabPageKirill.UseVisualStyleBackColor = true;

            // tabPageRoman
            this.tabPageRoman.Location = new System.Drawing.Point(4, 25);
            this.tabPageRoman.Name = "tabPageRoman";
            this.tabPageRoman.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoman.Size = new System.Drawing.Size(992, 571);
            this.tabPageRoman.TabIndex = 1;
            this.tabPageRoman.Text = "Вариант Роман";
            this.tabPageRoman.UseVisualStyleBackColor = true;

            // btnOpen
            this.btnOpen.Location = new System.Drawing.Point(30, 30);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(140, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть файл";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);

            // btnForecast
            this.btnForecast.Location = new System.Drawing.Point(30, 80);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(140, 40);
            this.btnForecast.TabIndex = 1;
            this.btnForecast.Text = "Построить прогноз";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 250);
            this.dataGridView1.TabIndex = 2;

            // chart1
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);

            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);

            this.chart1.Location = new System.Drawing.Point(450, 30);
            this.chart1.Name = "chart1";

            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";

            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(500, 400);
            this.chart1.TabIndex = 3;

            // numDays
            this.numDays.Location = new System.Drawing.Point(30, 130);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(120, 22);
            this.numDays.TabIndex = 4;

            // numPeriod
            this.numPeriod.Location = new System.Drawing.Point(170, 130);
            this.numPeriod.Name = "numPeriod";
            this.numPeriod.Size = new System.Drawing.Size(120, 22);
            this.numPeriod.TabIndex = 5;

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(320, 135);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(46, 17);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "label1";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Статистический анализ";

            this.tabControl1.ResumeLayout(false);
            this.tabPageKirill.ResumeLayout(false);
            this.tabPageKirill.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.NumericUpDown numPeriod;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageKirill;
        private System.Windows.Forms.TabPage tabPageRoman;
    }
}

