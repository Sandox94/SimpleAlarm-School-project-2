using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prosjekt
{
    public partial class SendEmail : Form
    {
        string emailAdress;
        List<string> fullEmailList;

        public SendEmail()
        {
            InitializeComponent();

            fullEmailList = SQLCommunication.SQL.GetFullEmailList();
            cboEmail.Items.Clear();

            foreach (string email in fullEmailList)
            {
                cboEmail.Items.Add(email);
            }
        }

        private void rdoOtherUser_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            cboEmail.Enabled = false;
            btnSendEmail.Enabled = false;
        }

        private void cboEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmail.Text != null) btnSendEmail.Enabled = true;
            else btnSendEmail.Enabled = false;

        }

        private void rdoUserInDatabase_CheckedChanged(object sender, EventArgs e)
        {
            cboEmail.Enabled = true;
            txtEmail.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != null) btnSendEmail.Enabled = true;
            else btnSendEmail.Enabled = false;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (rdoUserInDatabase.Checked) emailAdress = cboEmail.Text;
            else emailAdress = txtEmail.Text;
            Mail mail = new Mail(emailAdress, "Alarmliste på pdf", "Vedlagt ligger alarmliste på pdf", PdfForm.CompleteFilename);
            Task sendMail = Task.Factory.StartNew(() => mail.Send());
            Task.WaitAll(sendMail);
            if (mail.EmailSent)
            {
                MessageBox.Show("E-post sent!");
                this.Close();
            }
        }
    }
}
