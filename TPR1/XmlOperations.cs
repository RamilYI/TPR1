using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TPR1
{
    class XmlOperations
    {

        internal static void saveToXml(TabControl tabControl, int count, string name, string pathfiles)
        {
            for (int i = 0; i < count; i++)
            {
                string path = Path.Combine(pathfiles, name + i + ".xml");

                DataGridView dataGridView = new DataGridView();
                dataGridView = (DataGridView) tabControl.TabPages[i].Controls[0];
                
                DataTable  dt = new DataTable();

                foreach (DataGridViewColumn cols in dataGridView.Columns)
                {
                    dt.Columns.Add(cols.HeaderText);
                }

                foreach (DataGridViewRow rows in dataGridView.Rows)
                {
                    DataRow dataRow = dt.NewRow();
                    foreach (DataGridViewCell cells in rows.Cells)
                    {
                        dataRow[cells.ColumnIndex] = cells.Value;
                    }

                    dt.Rows.Add(dataRow);
                }
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                ds.WriteXml(path, XmlWriteMode.WriteSchema);
            }

        }

        internal static void readXml(TabControl tabControl, string name, string pathfiles)
        {
            
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                string path = Path.Combine(pathfiles, name + i + ".xml");
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(path, XmlReadMode.ReadSchema);
                DataGridView dataGridView = new DataGridView();
                dataGridView = (DataGridView)tabControl.TabPages[i].Controls[0];
                dataGridView.DataSource = dataSet.Tables[0];
            }
        }

    }
}
