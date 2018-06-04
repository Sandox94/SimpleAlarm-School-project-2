using SQLCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Prosjekt
{
    public partial class HistoricGraph : Form
    {
        public HistoricGraph()
        {
            InitializeComponent();
        }

        
        void UpdateGraph()
        {
            // Clear all points in graph
            graph.Series[0].Points.Clear();

            // Gets datatable with logged temperatures from database
            string sqlQuery;
            string dateFrom = string.Format("{0}.{1}.{2}", dateTimeFrom.Value.Year, dateTimeFrom.Value.Month, dateTimeFrom.Value.Day);
            string dateTo = string.Format("{0}.{1}.{2}", dateTimeTo.Value.Year, dateTimeTo.Value.Month, dateTimeTo.Value.Day + 1);
            sqlQuery = string.Format("SELECT Time as Tidspunkt, Temperature as Temperatur FROM Temperature WHERE Time >= '{0}' and Time < '{1}' ORDER BY Time", dateFrom, dateTo);
            DataTable table = SQL.MakeDataGridView(sqlQuery);

            // Adds each row to graph
            for (int i = 0; i < table.Rows.Count; i++)
            {
                graph.Series[0].Points.AddXY(table.Rows[i][0], table.Rows[i][1]);
            }
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }
    }
}
