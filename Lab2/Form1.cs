using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        IntervalStatisticalSeries Series;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += (s, e) => {
                bool a = e.KeyValue == (char)Keys.D0 || e.KeyValue == (char)Keys.D1 || e.KeyValue == (char)Keys.D2 ||
                e.KeyValue == (char)Keys.D3 || e.KeyValue == (char)Keys.D4 || e.KeyValue == (char)Keys.D5 || e.KeyValue == (char)Keys.D6 ||
                e.KeyValue == (char)Keys.D7 || e.KeyValue == (char)Keys.D8 || e.KeyValue == (char)Keys.D9 || e.KeyValue == (char)Keys.Enter;
                if (a) UpdateSize(); };
            CreatGrafics.Click += new EventHandler(OnButtonClick);

        }

        private void UpdateSize()
        {
            int a = dataGridView1.RowCount;
            if (a > 1)
            {
                dataGridView1.Size = new Size(200, a * 30 + 10);
            }
            return;
        }

        //Зчитування даних з форми
        private double[] ReadFromGridView()
        {
            List<double> Xi = new List<double>();
            DataGridViewRowCollection rows = dataGridView1.Rows;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                foreach (DataGridViewCell dc in dr.Cells)
                {
                    if (dc.Value == null) continue;
                    if (dc.Value.ToString() != "")
                    {
                        Regex regex = new Regex(@"^((-\d|\d)+(?:[\.\,]\d*)?)$");
                        MatchCollection collection = regex.Matches(dc.Value.ToString());
                        if (collection.Count > 0)
                        {
                            Xi.Add(Convert.ToDouble(dc.Value.ToString().Replace('.', ',')));
                        }
                        
                    } 
                }
            }
            return Xi.ToArray();
        }
        Button CreatGrafics = new Button();
        private void button1_Click(object sender, EventArgs e)
        {
            /*double[] arr=ReadFromGridView();
           if (arr.Length < 1)
           {
               return;
           }*/
            //double[] arr = new double[] { 0.29, 0.35, 0.34, 0.42, 0.47, 0.6, 0.91 };
            //double[] arr = new double[] { 0.14 , 0.28 , 0.31  , 0.57 , 0.65 , 0.78, 0.42, 0.47, 0.60, 0.91,
            //                              0.65  , 0.79 , 0.57  ,0.34 , 0.25 , 0.00, 0.03, 0.28, 0.33 , 0.33,
            //                              0.14 , 0.25, 0.31, 0.36, 0.65, 0.65, 0.70, 0.42, 0.47, 0.60  };
            double[] arr = new double[] { -0.23, -0.17, -0.04, 0.06, 0.19, 0.27 };
            //double[] arr = new double[] {-0.48, -0.34, -0.22, 0.24, 0.36, 0.51  };
            IntervalStatisticalSeries series = StatisticalSeries.DiscreteVariationDeries(arr);
            Series = series;
            StringBuilder output = new StringBuilder();

            double sat = StatisticalSeries.AverageStatistical(series);
            output.AppendLine($"Середнє статистиче: {sat}");
            double[] moda = StatisticalSeries.Moda(series);
            if (moda.Length == 0 || moda.Length == arr.Length)
            {
                output.AppendLine("Мода: немає");
            }
            else
            {
                output.Append("Мода: ");
                for (int i = 0; i < moda.Length; ++i)
                {
                    output.Append(String.Format("{0,-10}", moda[i]));
                }
                output.Append("\r\n");
            }
            double median = StatisticalSeries.Median(series);
            output.AppendLine($"Медіана: {median}");
            double range = StatisticalSeries.Range(series);
            output.AppendLine($"Розмах: {range}");
            double disper = StatisticalSeries.Dispersion(series);
            output.AppendLine($"Дисперсія: {disper}");
            double serkv = StatisticalSeries.AverageKvadr(series);
            output.AppendLine($"Середнє квадратичне відхилення: {serkv}");
            double vyprDysper = StatisticalSeries.VyprDispersion(series);
            output.AppendLine($"Виправлена дисперсія: {vyprDysper}");

            double vyprSerKv = StatisticalSeries.VyprAverageKvadr(series);
            output.AppendLine($"Виправлене квадратичне відхилення: {vyprSerKv}");
            double variacia = StatisticalSeries.Variation(series);
            output.AppendLine($"Варіація: {variacia}");
            if (textBox1.Text != "")
            {
                Regex regex = new Regex(@"\D");
                MatchCollection collection = regex.Matches(textBox1.Text);
                if (collection.Count == 0)
                {
                    double pm = StatisticalSeries.InitialMoment(series, Convert.ToInt32(textBox1.Text));
                    output.AppendLine($"Початковий момент {textBox1.Text}-порядку: {pm}");
                }
                else
                {
                    output.AppendLine($"Початковий момент n-порядку: Задайте порядок коректно");
                }
            }
            else
            {
                output.AppendLine($"Початковий момент n-порядку: Задайте порядок");
            }

            if (textBox2.Text != "")
            {
                Regex regex = new Regex(@"\D");
                MatchCollection collection = regex.Matches(textBox2.Text);
                if (collection.Count == 0)
                {
                    double cm = StatisticalSeries.CentrMoment(series, Convert.ToInt32(textBox2.Text));
                    output.AppendLine($"Центральний момент {textBox2.Text}-порядку: {cm}");
                }
                else
                {
                    output.AppendLine($"Центральний момент n-порядку: Задайте порядок коректно");
                }
            }
            else
            {
                output.AppendLine($"Центральний момент n-порядку: Задайте порядок");
            }


            double asym = StatisticalSeries.Assymetry(series);
            output.AppendLine($"Асиметрія: {asym}");
            double exec = StatisticalSeries.Excess(series);
            output.AppendLine($"Ексцес: {exec}");
            label.Text = output.ToString();
            //variationDeries = StatisticalSeries.DiscreteVariationDeries(arr);
            OutOnLabel(series);
            CreatGrafics.Location = new Point(100, 58);
            CreatGrafics.Size = new Size(130, 25);
            CreatGrafics.Text = "Побудувати графіки";
            this.Controls.Add(CreatGrafics);

            return;
        }
        private void OnButtonClick(object sender, EventArgs e)
        {
            Grafics grafics = new Grafics(Series.BeginInterval,Series.EndInterval,Series.N);
            grafics.Show();
        }
        private void OutOnLabel(IntervalStatisticalSeries series)
        {
            StringBuilder builder = new StringBuilder();
            int icon = 13;
            int field = 23;
            builder.AppendLine(new string('-', icon+ field* series.CountInterval));
            builder.Append("| X    |");
            for (int i = 0; i < series.CountInterval; i++)
            {
                builder.Append(String.Format("  [ {0}-{1} ]  |", series.BeginInterval[i].ToString("f2"), series.EndInterval[i].ToString("f2")));
            }
            builder.Append("\r\n");
            builder.AppendLine(new string('-', icon + field * series.CountInterval));
            builder.Append("| n    |");
            for (int i = 0; i < series.CountInterval; i++)
            {
                builder.Append(String.Format(" {0,19:f2}  |", series.N[i].ToString()));
            }
            builder.Append("\r\n");
            builder.AppendLine(new string('-', icon + field * series.CountInterval));

            builder.Append("| W  |");
            for (int i = 0; i < series.CountInterval; i++)
            {
                builder.Append(String.Format(" {0,16}  |",Math.Round(series.W[i],3)));
            }
            builder.Append("\r\n");
            builder.AppendLine(new string('-', icon + field * series.CountInterval));
            StatRiad.Text= builder.ToString();
            
        }
    }
}
