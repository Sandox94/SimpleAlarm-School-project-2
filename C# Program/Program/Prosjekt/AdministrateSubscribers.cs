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

namespace Prosjekt
{
    public partial class AdministrateSubscribers : Form
    {
        Subscriber sub;

        public AdministrateSubscribers()
        {
            InitializeComponent();

            UpdateTable();
        }


        private void dgvSubscribers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClearAll();
                DataGridViewRow row = this.dgvSubscribers.Rows[e.RowIndex];
                
                // Makes new subscriber object based on info in row
                sub = new Subscriber(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(), Convert.ToInt32(row.Cells[3].Value));

                // Displays in textboxes
                txtEMail.Text = sub.Email;
                txtFirstName.Text = sub.FirstName;
                txtLastName.Text = sub.LastName;
                txtPhoneNumber.Text = sub.Telephone.ToString();

                // Gets list with alarmtypes
                List<string> alarmList = SQL.GetSubscriberAlarmList(sub);

                // Add chk at beginning of each string so checkboxes could be checked
                for (int i = 0; i < alarmList.Count; i++)
                {
                    alarmList[i] = "chk" + alarmList[i];
                    alarmList[i] = alarmList[i].Replace(" ", "");
                }
                foreach (CheckBox chk in grpAlarmtypes.Controls)
                {
                    if (alarmList.Contains(chk.Name)) chk.Checked = true;
                }
            }
        }

        // When datasource in datagridview is successfully loaded, clear selection, so no row is active
        private void dgvSubscribers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSubscribers.ClearSelection();
        }

        private void btnUpdateSubscriber_Click(object sender, EventArgs e)
        {
            // Update subsriber in database
            SQL.UpdateSubscriber(sub, txtEMail.Text, txtFirstName.Text, txtLastName.Text, Convert.ToInt32(txtPhoneNumber.Text));

            // Update alarmtypes for subscriber
            foreach (CheckBox chk in grpAlarmtypes.Controls)
            {
                // Removes chk from checkbox-name, and casts string to AlarmtypesEnum. Then update alarmtype for subscriber
                string temp = chk.Name;
                temp = temp.Replace("chk", "");
                AlarmtypesEnum alarm = (AlarmtypesEnum)Enum.Parse(typeof(AlarmtypesEnum), temp);
                if (chk.Checked)
                    sub.SubscribeTo(alarm);
                if (!chk.Checked)
                    sub.UnsubscribeTo(alarm);
            }

            MessageBox.Show("Abonnent " + sub.Email + " oppdatert", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateTable();
        }

        private void btnDeleteSubsriber_Click(object sender, EventArgs e)
        {
            // Delete from database only if user answer yes in messagebox
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil slette " + sub.Email + " fra databasen?", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SQL.DeleteSubscriber(sub);
                UpdateTable();
                ClearAll();
            }
        }

        void UpdateTable()
        {
            string sqlQuery = @"SELECT Email as 'E-post', FirstName as Fornavn, LastName as Etternavn, Telephone as 'Tlf nummer'  From SUBSCRIBER";
            dgvSubscribers.DataSource = SQL.MakeDataGridView(sqlQuery);
        }

        // Clears all text- and checkboxes
        void ClearAll()
        {
            foreach (Control ctrl in pnlBoxes.Controls)
            {
                if (ctrl is TextBox) ((TextBox)ctrl).Clear();
            }
            foreach (CheckBox chkBox in grpAlarmtypes.Controls)
            {
                chkBox.Checked = false;
            }
        }
    }
}
