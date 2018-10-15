using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TPR1
{
    public partial class Dialog : Form
    {
        private int state, step;
        private List<Tuple<int, double, int, int>> res;

        public Dialog(int state, int step, List<Tuple<int, double, int, int>> res)
        {
            InitializeComponent();
            this.state = state;
            this.step = step;
            this.res = res;
            
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
            int meme = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainGraph mainGraph = new MainGraph();
            mainGraph.drawMainGraph(state, step, res);
            mainGraph.Show();
        }
    }
}
