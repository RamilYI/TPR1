using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR1
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }
        
        public void filltable(List<Tuple<int, double, int, int>> result)
        {
            data.Rows.Clear();
            data.Columns.Clear();
            data.DataSource = result;
            data.Columns[0].HeaderText = "шаг";
            data.Columns[1].HeaderText = "максимальное значение";
            data.Columns[2].HeaderText = "номер стратегии";
            data.Columns[3].HeaderText = "номер состояния";
        }

    }
}
