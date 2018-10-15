using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TPR1
{
    public partial class Form1 : Form
    {
        private List<Tuple<double[,],int>> objListProb = new List<Tuple<double[,], int>>();
        private List<Tuple<double[,], int>> objListVal = new List<Tuple<double[,], int>>();
        private bool flag;
        private List<DataGridView> saveDataGridProb = new List<DataGridView>();
        private List<DataGridView> saveDataGridVal = new List<DataGridView>();
        private List<Tuple<int,double,int, int>> result = new List<Tuple<int, double, int, int>>(); //strategy, value, index, state
        private List<double> maxnums = new List<double>();
        private int strategyC, stateC;
        public delegate int numericF(NumericUpDown x);

        public Form1()
        {
            InitializeComponent();
        }
        
        private int numericCount(NumericUpDown x)
        {
            return Int32.Parse(x.Value.ToString());
        }

        private void fillcombobox()
        {
            int K = strategyC;
            for (int i = 0; i < K; i++) changeStrategy.Items.Add("стратегия" + (i + 1));
            try
            {
                changeStrategy.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e + "\n\n" + "Введите данные!");
            }
        }

        private void fillTabControls(TabControl x, int z)
        {
            Matrix m = new Matrix(stateC, stateC);
            double[,] n = new double[stateC, stateC];
            TabPage tabPage = new TabPage();
            DataGridView dataGridView = new DataGridView();
            if (flag) saveDataGridVal.Add(dataGridView);
            else saveDataGridProb.Add(dataGridView);
            n = m.readtable(dataGridView);
            if (flag) objListVal.Add(new Tuple<double[,], int>(n, z));
            else objListProb.Add(new Tuple<double[,], int>(n, z));
            tabPage.Text = "стратегия " + (z + 1);
            tabPage.Controls.Add(dataGridView);
            x.TabPages.Add(tabPage);
            fillDataGridViews(dataGridView);
            dataGridView.Dock = DockStyle.Fill;
            flag = false;
        }

        private void fillDataGridViews(DataGridView data)
        {
            int N = stateC;
            data.ColumnCount = N;
            data.RowCount = N + 1;
            for (int i = 0; i < N; i++) data.Columns[i].Name = "состояние " + (i + 1);
            for (int i = 0; i < N; i++) for (int j = 0; j < N; j++) data.Rows[i].Cells[j].Value = 0.0;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            data.AllowUserToAddRows = false;
        }

        private void clearTabControls(TabControl x)
        {
            x.TabPages.Clear();
        }

        private void updatetable_Click(object sender, EventArgs e)
        {
            clearAllMatrixandResults();
            strategyC = numericCount(strategyCount);
            stateC = numericCount(stateCount);
            //stepC = numericCount(stepCount);
            for (int i = 0; i < strategyC; i++)
            {
                flag = true;
                fillTabControls(valueMatrix, i);
                fillTabControls(propabilityMatrix, i);
            }

            fillcombobox();
            try
            {
                drawGraph();
                calc.Enabled = true;
                loadTable.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("" + exception + "\n\n" + "введите данные!");
            }


        }
        
        private void clearAllMatrixandResults()
        {
            clearTabControls(valueMatrix);
            clearTabControls(propabilityMatrix);
            result.Clear();
            maxnums.Clear();
            objListProb.Clear();
            objListVal.Clear();
            changeStrategy.Items.Clear();
            saveDataGridProb.Clear();
            saveDataGridVal.Clear();
        }

        private void drawGraph()
        {
            String graph = "digraph ";
            double[,] n;
            int strategyselect = changeStrategy.SelectedIndex;
            n = objListProb[strategyselect].Item1;

            graph = makeGraph(graph, stateC, n);
            graphImageLtd.SizeMode = PictureBoxSizeMode.AutoSize;
            graphImageLtd.Image = Examples.Run(graph);
        }

        private static string makeGraph(string graph, int stateCounts, double[,] n)
        {
            graph += "{\n";
            graph += "node [shape=circle]\n";
            for (int i = 1; i <= stateCounts; i++)
            {
                for (int j = 1; j <= stateCounts; j++)
                {
                    graph += $"state{i}->state{j}[label = \"{n[i - 1, j - 1]}\", weight = \"{n[i - 1, j - 1]}\"];\n";
                }
            }

            graph += "}";
            return graph;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            result.Clear();
            maxnums.Clear();
            fixMatrixValues();
            Strategy m = new Strategy(stateC);
            List<double[]> q = new List<double[]>();
            for (int i = 0; i < strategyC; i++)
            {
                q.Add(m.qcalculation(objListProb, objListVal, i));
            }
            vCalc(q, numericCount);
            Dialog dialog = new Dialog(stateC, numericCount(stepCount), result);
            dialog.filltable(result);
            dialog.Show();
        }

        private void vCalc(List<double[]> q, numericF numericF)
        {
            double[] v = new double[strategyC];
            double steps = numericF(stepCount);
            for (int i = 0; i < steps + 1; i++)
            {
                for (int j = 0; j < stateC; j++)
                {
                    for (int k = 0; k < strategyC; k++)
                    {
                        v[k] = double.Parse(q[k].GetValue(j).ToString()) + summeth(i, objListProb, maxnums, j, k);
                    }

                    double maxValue = v.Max();
                    maxnums.Add(maxValue);
                    int maxIndex = v.ToList().IndexOf(maxValue);
                    result.Add(new Tuple<int, double, int, int>(i, maxValue, maxIndex+1, j + 1));
                }
                
            }
        }
        
        private double summeth(int i, List<Tuple<double[,], int>> objListProb, List<Double> maxnums, int j, int k)
        {
            if (i == 0) return 0.0;
            else
            {
                double sum = 0;
                double[,] list = new double[stateC, stateC];
                list = objListProb[j].Item1;
                    for (int m = 0; m < stateC; m++)
                    {
                        sum += list[j,m] * maxnums[m + stateC * (i - 1)];
                    }
                return sum;
            }
        }

        private void changeStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawGraph();
        }

        private void fixMatrixValues()
        {
            int N = numericCount(stateCount);
            int K = numericCount(strategyCount);

            Matrix m = new Matrix(N, N);
            double[,] n = new double[N, N];


            fixlists(m, n, K, objListProb, saveDataGridProb);
            fixlists(m, n, K, objListVal, saveDataGridVal);
            drawGraph();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = pathDefinition();
            XmlOperations.saveToXml(propabilityMatrix, strategyC, "propabilitymatrix", path);
            XmlOperations.saveToXml(valueMatrix, strategyC, "valuematrix", path);
            loadTable.Enabled = false;
        }

        private static string pathDefinition()
        {
            SaveFileDialog openFileDialog = new SaveFileDialog();
            string path = "нажмите сохранить";
            openFileDialog.FileName = path;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetDirectoryName(openFileDialog.FileName);
            }
            else
            {
                path = Application.StartupPath;
            }

            return path;
        }

        private static string folderdefinition()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string path = "откройте любой файл";
            openFileDialog.FileName = path;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetDirectoryName(openFileDialog.FileName);
            }
            else
            {
                path = Application.StartupPath;
            }

            return path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = folderdefinition();
            DialogResult dialogResult = MessageBox.Show("Ваши текущие таблицы будут стёрты. Вы готовы продолжить?", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                rebuildMatrix(valueMatrix);
                rebuildMatrix(propabilityMatrix);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            XmlOperations.readXml(propabilityMatrix, "propabilitymatrix", path);
            XmlOperations.readXml(valueMatrix, "valuematrix", path);
            loadTable.Enabled = false;
        }

        private void rebuildMatrix(TabControl x)
        {
            for (int i = 0; i < strategyC; i++)
            {
                DataGridView dataGridView = new DataGridView();
                dataGridView = (DataGridView) x.TabPages[i].Controls[0];
                dataGridView.Columns.Clear();
                dataGridView.Rows.Clear();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fixlists(Matrix m, double[,] n, int K, List<Tuple<double[,], int>> X, List<DataGridView> Y)
        {
            X.Clear();
            for (int i = 0; i < K; i++)
            {
                n = m.readtable(Y[i]);
                X.Add(new Tuple<double[,], int>(n, i));
            }
        }

    }
}
