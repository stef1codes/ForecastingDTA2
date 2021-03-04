namespace StefanSchmeltzPredictionDTA02
{
    partial class PredictionVisualization
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.months = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demands = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onestepforecast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForecastError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SquarredError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Months1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OneStepForecat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForecastError1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuarredError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.readDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(875, 41);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "SES";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "DES";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "TES";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(787, 520);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(27, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 580);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.months,
            this.Demands,
            this.onestepforecast,
            this.Estimate,
            this.ForecastError,
            this.SquarredError});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 555);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // months
            // 
            this.months.HeaderText = "months";
            this.months.MinimumWidth = 6;
            this.months.Name = "months";
            this.months.Width = 125;
            // 
            // Demands
            // 
            this.Demands.HeaderText = "Demands";
            this.Demands.MinimumWidth = 6;
            this.Demands.Name = "Demands";
            this.Demands.Width = 125;
            // 
            // onestepforecast
            // 
            this.onestepforecast.HeaderText = "One Step Forecast";
            this.onestepforecast.MinimumWidth = 6;
            this.onestepforecast.Name = "onestepforecast";
            this.onestepforecast.Width = 125;
            // 
            // Estimate
            // 
            this.Estimate.HeaderText = "Estimate";
            this.Estimate.MinimumWidth = 6;
            this.Estimate.Name = "Estimate";
            this.Estimate.Width = 125;
            // 
            // ForecastError
            // 
            this.ForecastError.HeaderText = "Forecast Error";
            this.ForecastError.MinimumWidth = 6;
            this.ForecastError.Name = "ForecastError";
            this.ForecastError.Width = 125;
            // 
            // SquarredError
            // 
            this.SquarredError.HeaderText = "Squarred Error";
            this.SquarredError.MinimumWidth = 6;
            this.SquarredError.Name = "SquarredError";
            this.SquarredError.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(834, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Months1,
            this.Demand1,
            this.Alpha,
            this.Trend,
            this.OneStepForecat1,
            this.ForecastError1,
            this.SuarredError});
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(831, 548);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Months1
            // 
            this.Months1.HeaderText = "Months1";
            this.Months1.MinimumWidth = 6;
            this.Months1.Name = "Months1";
            this.Months1.Width = 125;
            // 
            // Demand1
            // 
            this.Demand1.HeaderText = "Demand1";
            this.Demand1.MinimumWidth = 6;
            this.Demand1.Name = "Demand1";
            this.Demand1.Width = 125;
            // 
            // Alpha
            // 
            this.Alpha.HeaderText = "Alpha";
            this.Alpha.MinimumWidth = 6;
            this.Alpha.Name = "Alpha";
            this.Alpha.Width = 125;
            // 
            // Trend
            // 
            this.Trend.HeaderText = "Trend";
            this.Trend.MinimumWidth = 6;
            this.Trend.Name = "Trend";
            this.Trend.Width = 125;
            // 
            // OneStepForecat1
            // 
            this.OneStepForecat1.HeaderText = "OneStepForecat1";
            this.OneStepForecat1.MinimumWidth = 6;
            this.OneStepForecat1.Name = "OneStepForecat1";
            this.OneStepForecat1.Width = 125;
            // 
            // ForecastError1
            // 
            this.ForecastError1.HeaderText = "ForecastError1";
            this.ForecastError1.MinimumWidth = 6;
            this.ForecastError1.Name = "ForecastError1";
            this.ForecastError1.Width = 125;
            // 
            // SuarredError
            // 
            this.SuarredError.HeaderText = "SuarredError1";
            this.SuarredError.MinimumWidth = 6;
            this.SuarredError.Name = "SuarredError";
            this.SuarredError.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(834, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // readDataBindingSource
            // 
            this.readDataBindingSource.DataSource = typeof(StefanSchmeltzPredictionDTA02.DataReader.readData);
            // 
            // PredictionVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 753);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1742, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "PredictionVisualization";
            this.Text = "PredictionVisualization";
            this.Load += new System.EventHandler(this.PredictionVisualization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource readDataBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn months;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demands;
        private System.Windows.Forms.DataGridViewTextBoxColumn onestepforecast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForecastError;
        private System.Windows.Forms.DataGridViewTextBoxColumn SquarredError;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Months1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trend;
        private System.Windows.Forms.DataGridViewTextBoxColumn OneStepForecat1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForecastError1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuarredError;
        private System.Windows.Forms.TabPage tabPage3;
    }
}