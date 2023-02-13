using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class DiscreteVariationDeries
    {
        private double[] elems;
        private int[] n;
        private double[] w;
        public DiscreteVariationDeries(double[] elems, int[] n, double[] w)
        {
            this.elems = elems;
            this.n = n;
            this.w = w;
        }
        public double[] Elems
        {
            get 
            {
                return elems;
            }
        }
        public int[] N
        {
            get
            {
                return n;
            }
        }
        public double[] W
        {
            get
            {
                return w;
            }
        }
    }
}
