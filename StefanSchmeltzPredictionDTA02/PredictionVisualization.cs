using StefanSchmeltzPredictionDTA02.DataReader;
using StefanSchmeltzPredictionDTA02.ForecastingModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StefanSchmeltzPredictionDTA02
{
    public partial class PredictionVisualization : Form
    {
        readData dataset = new readData();


        private void PredictionVisualization_Load(object sender, EventArgs e)
        {
            var dt = dataset.getData();

            SES ses = new SES(dt);
            DES des = new DES(dt);
            TES tes = new TES(dt);

            // var sesSmoothing = ses.SmoothingCalculation(12);
            var sesSmoothing2 = ses.SmoothingCalculation2(12,0.73,dt,12);
            var desSmoothing2 = des.SmoothingCalculation2(12,0.659100046560163, 0.0531171804609812,dt,12,155,0.8369);


            //actual data
            ApplyActualDataToChart(chart1, dt, "Data");
            ApplySESDataToChart(chart1, sesSmoothing2, "SES");
            ApplyDESDataToChart(chart1, desSmoothing2, "DES");
            //ApplyDataToChart(chart1, tes, "TES");

            // ses data to gridview
            for (int i = 0; i < sesSmoothing2.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = i + 1;//row number
                    row.Cells[1].Value = sesSmoothing2[i].Item1;
                    row.Cells[2].Value = sesSmoothing2[i].Item2;
                    row.Cells[3].Value = sesSmoothing2[i].Item3;
                    row.Cells[4].Value = sesSmoothing2[i].Item4;
                    row.Cells[5].Value = sesSmoothing2[i].Item5;
                    dataGridView1.Rows.Add(row);
                }
            // des data to gridview
            for (int i = 0; i < desSmoothing2.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();

                row.Cells[0].Value = i + 1;//row number
                row.Cells[1].Value = desSmoothing2[i].Item1;
                row.Cells[2].Value = desSmoothing2[i].Item2;
                row.Cells[3].Value = desSmoothing2[i].Item3;
                row.Cells[4].Value = desSmoothing2[i].Item4;
                row.Cells[5].Value = desSmoothing2[i].Item5;
                row.Cells[6].Value = desSmoothing2[i].Item6;
                dataGridView2.Rows.Add(row);
            }

        }

        private void ApplyDESDataToChart(Chart chart1, List<Tuple<double, double, double, double, double, double>> desSmoothing2, string line)
        {
            for (int i = 0; i < desSmoothing2.Count; i++)
            {
                if (desSmoothing2[i].Item2 != 0)
                {
                    chart1.Series[line].Points.AddXY(i + 1, desSmoothing2[i].Item2);
                }
                else
                {
                    chart1.Series[line].Points.AddXY(i + 1, desSmoothing2[i].Item1);
                }
            }
        }

        private void ApplySESDataToChart(Chart chart1, List<Tuple<double, double, double, double, double>> sesSmoothing2, string line)
        {
            for (int i = 0; i < sesSmoothing2.Count; i++)
            {
                if (sesSmoothing2[i].Item2 != 0)
                {
                    chart1.Series[line].Points.AddXY(i + 1, sesSmoothing2[i].Item2);
                }
                else
                {
                    chart1.Series[line].Points.AddXY(i + 1, sesSmoothing2[i].Item1);
                }
            }
        }
        private void ApplyActualDataToChart(Chart chart1, List<double> dataset, string line)
        {
            for (int i = 0; i < dataset.Count; i++)
            {
                chart1.Series[line].Points.AddXY(i + 1, dataset[i]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.Rows[e.RowIndex].Cells[0].Value =   e.RowIndex + 1;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public PredictionVisualization()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
