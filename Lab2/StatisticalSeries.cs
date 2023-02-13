using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class StatisticalSeries
    {
        public static IntervalStatisticalSeries DiscreteVariationDeries(double[] arr)
        {
            if (!(arr.Length > 0)) throw new ArgumentNullException();
            int countProm =Convert.ToInt32(1 + 3.322 * Math.Log10(arr.Length));
            double h = (arr.Max() - arr.Min()) / countProm;
            h = Math.Round(h, 3);//+0.00001;
            List<double> beginInterval = new List<double>();
            List<double> endInterval = new List<double>();
            beginInterval.Add(arr.Min());
            for (int i = 0; i < countProm; i++)
            {
                endInterval.Add(beginInterval[i]+h);
                if (i < countProm - 1)
                {
                    beginInterval.Add(beginInterval[i] + h);
                }
            }
            int[] N = new int[countProm];
            Array.Sort(arr);
            int k = 0;
            for (int i = 0; i < countProm; i++)
            {
                for (int j = k; j < arr.Length; j++)
                {
                    if (arr[j] > endInterval[i])
                    {
                        k = j;
                        break;
                    }
                    N[i]++;
                }
            }
            return new IntervalStatisticalSeries(beginInterval.ToArray(), endInterval.ToArray(), N);
        }

        //обчислення середнього статистичного
        public static double AverageStatistical(IntervalStatisticalSeries series)
        {
            if (series == null)
                throw new ArgumentNullException();
            double sum = 0;
            for (int i = 0; i < series.CountInterval; i++)
            {
                sum += series.MiddleValueInCurrInterval(i) * series.N[i];
            }
            return sum / series.ArrLength;
        }
        
        //обчислення модальних інтервалів
        public static int[] intervalModa(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            List<int> maxX = new List<int>();

            int max = series.N[0];
            maxX.Add(0);
            for (int i = 1; i < series.CountInterval; i++)
            {
                if (max < series.N[i])
                {
                    max = series.N[i];
                    maxX.Clear();
                    maxX.Add(i);
                }
                else if(max == series.N[i])
                {
                    maxX.Add(i);
                }
            }
            return maxX.ToArray();
        }

        //обчислення моди
        public static double[] Moda(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            int[] modeInterval = intervalModa(series);
            double[] modes = new double[modeInterval.Length];
            for (int i = 0; i < modeInterval.Length; i++)
            {
                //double denominator = (series.N[modeInterval[i]] - series.N[modeInterval[i] - 1]) + (series.N[modeInterval[i]] - series.N[modeInterval[i] + 1]);
                //double numerator = (series.N[modeInterval[i]] - series.N[modeInterval[i] - 1]);
                //modes[i] = series.BeginInterval[modeInterval[i]] + series.H * (numerator / denominator);
            }
            return modes;
        }

        //обчислення розмах вибірки
        public static double Range(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            return series.EndInterval[series.CountInterval-1] - series.BeginInterval[0];
        }

        //обчислення інтервалу медіани
        public static int IntervalMedian(IntervalStatisticalSeries series) 
        {
            if (series == null) throw new ArgumentNullException();
            int sumN = 0;
            int indexIntervalMedian = 0;
            for (int i = 0; i < series.CountInterval; i++)
            {
                sumN += series.N[i];
                if (sumN >= (series.ArrLength / 2))
                {
                    indexIntervalMedian = i;
                    break;
                }
            }
            return indexIntervalMedian;
        }

        //обчислення медіани
        public static double Median(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            int indexIntervalMedian = IntervalMedian(series);
            int sunNBeforeMedianInterval = 0;
            for (int i = 0; i < indexIntervalMedian; i++)
            {
                sunNBeforeMedianInterval += series.N[i];
            }
            double median = (series.H / series.N[indexIntervalMedian]) * ((series.ArrLength / 2.0) - sunNBeforeMedianInterval);
            median += series.BeginInterval[indexIntervalMedian];
            return median;
        }

        
        //обчислення дисперсії
        public static double Dispersion(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            double dispersia = 0;
            for (int i = 0; i < series.CountInterval; i++)
            {
                dispersia += series.N[i]* Math.Pow(series.MiddleValueInCurrInterval(i), 2);
            }
            
            dispersia /= series.ArrLength;
            dispersia -= Math.Pow(AverageStatistical(series), 2);
            return dispersia;
        }

        //обчислення початкового моменту (параметр order-порядок)
        public static double InitialMoment(IntervalStatisticalSeries series, int order)
        {
            if (series == null) throw new ArgumentNullException();
            double initialMoment = 0;
            for (int i = 0; i < series.CountInterval; ++i)
            {
                initialMoment += series.N[i]*Math.Pow(series.MiddleValueInCurrInterval(i), order);
            }
            initialMoment /= series.ArrLength;
            return initialMoment;
        }

        //обчислення центрального моменту (параметр order-порядок)
        public static double CentrMoment(IntervalStatisticalSeries series, int order)
        {
            if (series == null) throw new ArgumentNullException();
            double averStat = AverageStatistical(series);
            double centrMoment = 0;
            for (int i = 0; i < series.CountInterval; i++)
            {
                centrMoment +=series.N[i] * Math.Pow(series.MiddleValueInCurrInterval(i) - averStat, order);
            }
            centrMoment /= series.ArrLength;
            return centrMoment;
        }

        //обчислення середнього квадратичного
        public static double AverageKvadr(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            double averageKvadr = Dispersion(series);
            averageKvadr = Math.Sqrt(averageKvadr);
            return averageKvadr;
        }

        //обчислення виправленої дисперсії
        public static double VyprDispersion(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            double vyprDispersion = Dispersion(series) * (((double)series.ArrLength) / (series.ArrLength - 1));
            return vyprDispersion;
        }

        //обчислення виправленого середнього квадратичного
        public static double VyprAverageKvadr(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            double averageKvadr = VyprDispersion(series);
            averageKvadr = Math.Sqrt(averageKvadr);
            return averageKvadr;
        }

        //обчислення варіації
        public static double Variation(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            double a = AverageKvadr(series);
            double b = AverageStatistical(series);
            return a / b;
        }

        //обчислення асиметрії
        public static double Assymetry(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            return (CentrMoment(series, 3) / Math.Pow(AverageKvadr(series), 3));
        }

        //обчислення ексцесу
        public static double Excess(IntervalStatisticalSeries series)
        {
            if (series == null) throw new ArgumentNullException();
            return (CentrMoment(series, 4) / Math.Pow(AverageKvadr(series), 4)) - 3;
        }
    }

}
