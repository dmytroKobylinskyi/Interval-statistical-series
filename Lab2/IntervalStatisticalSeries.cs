using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class IntervalStatisticalSeries
    {
        public double[] BeginInterval { get; private set; }
        public double[] EndInterval { get; private set; }
        public int[] N { get; private set; }
        public double[] W { get; private set; }
        public int CountInterval{ get; private set; }
        public double H { get; private set; }
        public int ArrLength { get; private set; }
        public IntervalStatisticalSeries(double [] BeginInterval, double[] EndInterval, int [] N)
        {
            this.BeginInterval = BeginInterval;
            this.EndInterval = EndInterval;
            CountInterval = BeginInterval.Length;
            this.N = N;
            this.H =EndInterval[0] - BeginInterval[0];
            ArrLength = N.Sum();
            W=CalculationW(N, ArrLength);
        }
        private double[] CalculationW(int[] N, int allElem)
        {
            double[] tempW = new double[N.Length];
            for (int i = 0; i < N.Length; i++)
            {
                tempW[i] = Convert.ToDouble(N[i]) / allElem;
            }
            return tempW;
        }
        public double MiddleValueInCurrInterval(int i)
        {
            if (i >= CountInterval)
               throw new IndexOutOfRangeException();
            return (BeginInterval[i] + EndInterval[i])/2;
        }
    }
}
