using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR1
{
    class Strategy
    {
        private Matrix propability;
        private Matrix value;
        private int count;

        public Strategy(int count)
        {
            this.count = count;
            propability = new Matrix(count, count);
            value = new Matrix(count, count);
        }

        internal double[] qcalculation(List<Tuple<double[,], int>> data1, List<Tuple<double[,], int>> data2, int x)
        {
            //propability.readtable(data1);
            //value.readtable(data2);
            double [,] a = new double[count, count];
            double[,] b = new double[count, count];
            double[] q = new double[count];
            a = data1[x].Item1;
            b = data2[x].Item1;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    q[i] += a[i,j] * b[i,j];
                }
            }

            return q;
        }
    }
}
