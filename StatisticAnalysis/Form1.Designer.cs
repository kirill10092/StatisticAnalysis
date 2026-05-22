namespace StatisticAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">true, если управляемый ресурс должен быть удален; иначе false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKirill = new System.Windows.Forms.TabPage();
            this.textBoxAnalysis = new System.Windows.Forms.TextBox();
            this.numPeriod = new System.Windows.Forms.NumericUpDown();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnForecast = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabPageRoman = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageKirill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageKirill);
            this.tabControl1.Controls.Add(this.tabPageRoman);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageKirill
            // 
            this.tabPageKirill.Controls.Add(this.label2);
            this.tabPageKirill.Controls.Add(this.label1);
            this.tabPageKirill.Controls.Add(this.textBoxAnalysis);
            this.tabPageKirill.Controls.Add(this.numPeriod);
            this.tabPageKirill.Controls.Add(this.numDays);
            this.tabPageKirill.Controls.Add(this.chart1);
            this.tabPageKirill.Controls.Add(this.dataGridView1);
            this.tabPageKirill.Controls.Add(this.btnForecast);
            this.tabPageKirill.Controls.Add(this.btnOpen);
            this.tabPageKirill.Location = new System.Drawing.Point(4, 22);
            this.tabPageKirill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageKirill.Name = "tabPageKirill";
            this.tabPageKirill.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageKirill.Size = new System.Drawing.Size(892, 502);
            this.tabPageKirill.TabIndex = 0;
            this.tabPageKirill.Text = "Вариант 16";
            this.tabPageKirill.UseVisualStyleBackColor = true;
            // 
            // textBoxAnalysis
            // 
            this.textBoxAnalysis.Location = new System.Drawing.Point(16, 288);
            this.textBoxAnalysis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAnalysis.Multiline = true;
            this.textBoxAnalysis.Name = "textBoxAnalysis";
            this.textBoxAnalysis.ReadOnly = true;
            this.textBoxAnalysis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnalysis.Size = new System.Drawing.Size(338, 98);
            this.textBoxAnalysis.TabIndex = 6;
            // 
            // numPeriod
            // 
            this.numPeriod.Location = new System.Drawing.Point(131, 73);
            this.numPeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numPeriod.Name = "numPeriod";
            this.numPeriod.Size = new System.Drawing.Size(112, 20);
            this.numPeriod.TabIndex = 3;
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(131, 32);
            this.numDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(112, 20);
            this.numDays.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(375, 20);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(488, 366);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 165);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnForecast
            // 
            this.btnForecast.Location = new System.Drawing.Point(16, 61);
            this.btnForecast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(111, 32);
            this.btnForecast.TabIndex = 1;
            this.btnForecast.Text = "Сделать прогноз";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 17);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(111, 35);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть файл";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tabPageRoman
            // 
            this.tabPageRoman.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageRoman.Name = "tabPageRoman";
            this.tabPageRoman.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageRoman.Size = new System.Drawing.Size(892, 502);
            this.tabPageRoman.TabIndex = 1;
            this.tabPageRoman.Text = "Вариант 6";
            this.tabPageRoman.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Кол-во лет прогноза";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "n для скользящей кривой";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 528);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Статистический анализ";
            this.tabControl1.ResumeLayout(false);
            this.tabPageKirill.ResumeLayout(false);
            this.tabPageKirill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}