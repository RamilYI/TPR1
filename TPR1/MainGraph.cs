using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR1
{
    public partial class MainGraph : Form
    {
        public MainGraph()
        {
            InitializeComponent();
        }

        internal void drawMainGraph(int stateC, int stepCount, List<Tuple<int, double, int, int>> result)
        {
            int totalizer = 0;
            String graph = "digraph ";
            graph += "{\n";
            graph += "{\n";
            graph += "node [shape = plaintext, fontsize = 16];\n";
            for (int i = 0; i <= stepCount; i++)
            {
                graph += $"шаг{i} ->";
            }
            graph = graph.Substring(0, (graph.Length - 2));
            graph += ";\n";
            graph += "}\n";

            for (int i = 1; i <= stateC; i++)
            {
                graph += $"subgraph cluster_{i} ";
                graph += "{\n";
                graph += $"label=\"state {i}\";\n" +
                         $"node [shape=circle]\n";
                
                for (int k = 0; k <= stepCount; k++)
                {
                    graph += $"{i}{k} [label=\"state{i}\"];\n";

                }

                for (int j = 0; j < stepCount; j++)
                {
                   graph += $"{i}{j} ->{i}{j + 1}[label = \"{result[(i - 1) + stepCount * (i -1)].Item3}\", weight=\"{result[(i - 1) + stepCount * (i - 1)].Item3}\"];\n";
                }

                graph += "}\n";
            }

            graph += "}";
            graphBox.SizeMode = PictureBoxSizeMode.AutoSize;
            graphBox.Image = Examples.Graphviz.RenderImage(graph, "jpg");
        }
    }
}
