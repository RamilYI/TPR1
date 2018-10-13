using System;
using System.Globalization;
using System.Windows.Forms;

namespace TPR1
{
    public class Matrix
    {
        private int i;
        private int j;
        //public double[,] matrix;

        public Matrix(int i, int j)
        {
            this.i = i;
            this.j = j;
            //matrix = new double[i, j];
        }

        internal  double[,] readtable(DataGridView data)
        {
            double[,] matrix = new double[i, j];
            String buf;
            foreach (DataGridViewRow rows in data.Rows)
            {
                foreach (DataGridViewColumn columns in data.Columns)
                {
                    buf = data.Rows[rows.Index].Cells[columns.Index].Value.ToString();
                    matrix[rows.Index, columns.Index] = Convert.ToDouble(buf, CultureInfo.InvariantCulture);
                }
            }

            return matrix;
        }

    }
}
