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
    public partial class ServerConnect : Form
    {
        public ServerConnect()
        {
            InitializeComponent();
        }

        // Checks connection, and if it is successfull, open Home form
        private void btnConnect_Click(object sender, EventArgs e)
        {
            SQLCom.StartCom(txtServerName.Text);
            if (SQLCom.SuccessfullLogin == true)
            {
                SQL.ConnectionString = SQLCom.ConnectionString;
                this.Close();
            }
            else if (SQLCom.SuccessfullLogin == false)
            {
                MessageBox.Show("Feil ved innlogging til database. Har du skrivet rett servernavn?", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Det oppstod en uventet feil ved innlogging til database. Vennligst kontakt programutvikler. Programmet vil nå avsluttes", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Quit application if cancel is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServerConnect_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SQLCom.SuccessfullLogin == false)
            {
            Application.Exit();
            }
        }
    }
}
