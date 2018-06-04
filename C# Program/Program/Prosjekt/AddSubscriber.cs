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
    public partial class AddSubscriber : Form
    {
        public AddSubscriber()
        {
            InitializeComponent();
        }

        // Close form if cancel-button is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool resultTlfConvert;
            string email = txtEMail.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            Int32 tlfNumber;
            resultTlfConvert = int.TryParse(txtPhoneNumber.Text, out tlfNumber);

            // Test if txtPhoneNumber successfully converts to int
            if (resultTlfConvert == true)
            {
                Subscriber sub = new Subscriber(email, firstName, lastName, tlfNumber);

                // Add subscriber if it don't exist in database
                if (!SQL.SubscriberExists(sub))
                {
                    SQL.AddSubscriber(sub);
                    foreach (CheckBox chk in grpAlarmtypes.Controls)
                    {
                        if (chk.Checked)
                        {
                            // Removes chk from checkbox-name, and casts string to AlarmtypesEnum. Then it subscribes to alarmtype.
                            string temp = chk.Name;
                            temp = temp.Replace("chk", "");
                            AlarmtypesEnum alarm = (AlarmtypesEnum)Enum.Parse(typeof(AlarmtypesEnum), temp);
                            sub.SubscribeTo(alarm);
                        }
                    }
                    MessageBox.Show("Bruker lagt til i databasen", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                // If subscriber exists, display error-message
                else if (SQL.SubscriberExists(sub)) MessageBox.Show("Bruker med samme e-post eksisterer i databasen", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Display this error-message if everything else fails
                else MessageBox.Show("Oppretting av bruker feilet", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Converting to int fails of txtPhoneNumber holds characters
            else
            {
                MessageBox.Show("Telefonnummer skal kun inneholde tall", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
