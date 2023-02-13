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

namespace Lab1
{
    public partial class Grafics : Form
    {
        IntervalStatisticalSeries Series;
        public Grafics(double[] beginInterval, double[] endInterval, int[] N)
        {
            InitializeComponent();
            Series = new IntervalStatisticalSeries(beginInterval, endInterval, N);
        }
        List<Series> Myseries = new List<Series>();
        private void ClearMyseries()
        {
            if (Myseries.Count > 0)
            {
                foreach (var series in Myseries)
                {
                    series.Points.Clear();
                    chart1.Series.Remove(series);
                }
                Myseries.Clear();
            }
        }

        private void побудуватиГрафікиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMyseries();
            if (radioButton_polgonChastotamy.Checked == false && radioButton_polgonWidnosChastotamy.Checked == false && radioButton_KumZaWidnChast.Checked == false && radioButton_KumZaChast.Checked == false && radioButton_Empirychna.Checked == false)
            {
                MessageBox.Show("Виберіть, який графік побудувати!", "Увага!");
            }
            if (radioButton_polgonChastotamy.Checked == true)
            {
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart1.Visible = false;
                this.chart2.Visible = true;
                this.chart2.Dock = DockStyle.Fill;
                for (int i = 0; i < Series.CountInterval; i++)
                {
                    var series = new Series();
                    Myseries.Add(series);
                    string text = i + 1 == Series.CountInterval
                        ? $"[{Math.Round(Series.BeginInterval[i], 3)}; {Math.Round(Series.EndInterval[i], 3)}]"
                        : $"[{Math.Round(Series.BeginInterval[i], 3)}; {Math.Round(Series.EndInterval[i], 3)})";

                    series.Points.AddXY("", Series.N[i]);

                    this.chart2.Series.Add(series);
                    series.Label = text;
                    series.LabelBackColor = Color.White;
                    series["PointWidth"] = "2";
                }
                this.chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                this.chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                this.chart2.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                this.chart2.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                this.chart2.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            }
            else if (radioButton_polgonWidnosChastotamy.Checked == true)
            {
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart1.Visible = false;
                this.chart2.Visible = true;
                this.chart2.Dock = DockStyle.Fill;
                for (int i = 0; i < Series.CountInterval; i++)
                {
                    var series = new Series();
                    Myseries.Add(series);
                    string text = i + 1 == Series.CountInterval
                        ? $"[{Math.Round(Series.BeginInterval[i], 3)}; {Math.Round(Series.EndInterval[i], 3)}]"
                        : $"[{Math.Round(Series.BeginInterval[i], 3)}; {Math.Round(Series.EndInterval[i], 3)})";

                    series.Points.AddXY("", Series.W[i]);

                    this.chart2.Series.Add(series);
                    series.Label = text;
                    series.LabelBackColor = Color.White;
                    series["PointWidth"] = "2";
                }
                this.chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                this.chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                this.chart2.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                this.chart2.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                this.chart2.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            }
            else if (radioButton_KumZaChast.Checked == true)
            {
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart1.Visible = true;
                this.chart2.Visible = false;
                int sum = 0;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Interval = Math.Round((Series.EndInterval[Series.CountInterval-1] - Series.BeginInterval[0]) / 15, 2);
                for (int i = 0; i < Series.CountInterval; i++)
                {
                    sum += Series.N[i];
                    this.chart1.Series[0].Points.AddXY(Series.MiddleValueInCurrInterval(i), sum);
                    this.chart1.Series[1].Points.AddXY(Series.MiddleValueInCurrInterval(i), sum);
                }
            }
            else if (radioButton_KumZaWidnChast.Checked == true)
            {
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                this.chart1.Visible = true;
                this.chart2.Visible = false;
                double sum = 0;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Interval = Math.Round((Series.EndInterval[Series.CountInterval - 1] - Series.BeginInterval[0]) / 15, 2);
                for (int i = 0; i < Series.CountInterval; i++)
                {
                    sum += Series.W[i];
                    this.chart1.Series[0].Points.AddXY(Series.MiddleValueInCurrInterval(i), sum);
                    this.chart1.Series[1].Points.AddXY(Series.MiddleValueInCurrInterval(i), sum);
                }
            }
            else if (radioButton_Empirychna.Checked == true)
            {

                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart2.Series[0].Points.Clear();
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum= Series.EndInterval[Series.CountInterval - 1];
                this.chart1.Visible = true;
                this.chart2.Visible = false;
                chart1.ChartAreas[0].AxisX.Interval = Math.Round((Series.EndInterval[Series.CountInterval - 1] - Series.BeginInterval[0]) / 15, 2);
                double height = 0; 
                for (int i = 0; i < Series.CountInterval + 1; i++)
                {
                    Series mySeries = new Series();
                    mySeries.ChartType = SeriesChartType.Line;
                    mySeries.BorderWidth = 3;
                    mySeries.Color = Color.Blue;
                    if (i < 1)
                    {
                        mySeries.Points.AddXY(Series.BeginInterval[i], height);
                        this.chart1.Series[1].Points.AddXY(Series.BeginInterval[i], height);
                        mySeries.Points.AddXY(Series.MiddleValueInCurrInterval(i), height);
                        this.chart1.Series[1].Points.AddXY(Series.MiddleValueInCurrInterval(i), height);
                        height += Series.W[i];
                    }
                    else if (i < Series.CountInterval)
                    {
                        mySeries.Points.AddXY(Series.MiddleValueInCurrInterval(i-1), height);
                        this.chart1.Series[1].Points.AddXY(Series.MiddleValueInCurrInterval(i - 1), height);
                        mySeries.Points.AddXY(Series.MiddleValueInCurrInterval(i), height);
                        this.chart1.Series[1].Points.AddXY(Series.MiddleValueInCurrInterval(i), height);
                        height += Series.W[i];
                    }
                    else
                    {
                        mySeries.Points.AddXY(Series.MiddleValueInCurrInterval(i - 1) + 0.2, height);
                        mySeries.Points.AddXY(Series.MiddleValueInCurrInterval(i - 1), height);
                        this.chart1.Series[1].Points.AddXY(Series.MiddleValueInCurrInterval(i - 1), height);
                    }
                    chart1.Series.Add(mySeries);
                    Myseries.Add(mySeries);
                }
               
            }
        }

        private void видалитиГрафікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart2.Series[0].Points.Clear();
            ClearMyseries();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
