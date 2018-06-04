using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLCommunication;
using System.IO;

namespace Prosjekt
{
    public partial class AlarmList : Form
    {
        string sqlQuery;

        public AlarmList()
        {
            InitializeComponent();

            UpdateAlarmListAll();
        }

        // Update alarmlist table with all alarms
        void UpdateAlarmListAll()
        {
            sqlQuery = @"SELECT Alarm as Alarmtype, Time as Tidspunkt FROM ALARM ORDER BY Time DESC";
            dgvAlarms.DataSource = SQL.MakeDataGridView(sqlQuery);
        }

        // Update alarmlist table based on date
        void UpdateAlarmListBetweenDates()
        {
            string dateFrom = string.Format("{0}.{1}.{2}",dateTimeFrom.Value.Year, dateTimeFrom.Value.Month, dateTimeFrom.Value.Day);
            string dateTo = string.Format("{0}.{1}.{2}", dateTimeTo.Value.Year, dateTimeTo.Value.Month, dateTimeTo.Value.Day+1);
            sqlQuery = string.Format("SELECT Alarm as Alarmtype, Time as Tidspunkt FROM ALARM WHERE Time >= '{0}' and Time < '{1}' ORDER BY Time DESC", dateFrom, dateTo);
            dgvAlarms.DataSource = SQL.MakeDataGridView(sqlQuery);
        }
        
        void CreatePdf()
        {
            if (rdoShowAllAlarms.Checked) PdfForm.CreatePdf("Viser alle alarmer i databasen", SQL.MakeDataGridView(sqlQuery));
            else
            {
                string header = string.Format("Viser alarmer fra {0}, til og med {1}", dateTimeFrom.Text, dateTimeTo.Text);
                PdfForm.CreatePdf(header, SQL.MakeDataGridView(sqlQuery));
            }
        }

        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            CreatePdf();
        }

        // Open sendmail form
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            CreatePdf();
            SendEmail frmSendEmail = new SendEmail();
            frmSendEmail.ShowDialog(this);
        }

        #region Disable/enable controls
        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            UpdateAlarmListBetweenDates();
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            UpdateAlarmListBetweenDates();
        }

        private void rdoShowFromTo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeFrom.Enabled = true;
            dateTimeTo.Enabled = true;
            UpdateAlarmListBetweenDates();
        }

        private void rdoShowAllAlarms_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeFrom.Enabled = false;
            dateTimeTo.Enabled = false;
            UpdateAlarmListAll();
        }
        #endregion
    }
}
