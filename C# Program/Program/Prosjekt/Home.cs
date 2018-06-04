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
using System.Windows.Forms.DataVisualization.Charting;

namespace Prosjekt
{
    public partial class Home : Form
    {
        ArduinoCom arduinoCom;
        Arduino arduino;

        AlarmNoCharge noChargeAlarm;
        AlarmLowBattery lowBatteryAlarm;
        AlarmLowTemperature lowTemperatureAlarm;
        AlarmHighTemperature highTemperatureAlarm;
        AlarmMotion motionAlarm;
        AlarmComFault comFaultAlarm;

        List<string> emailList = new List<string>();
        Mail[] mailArray;

        const int timeListLength = 20;
        List<double> temperatureList = new List<double>();
        List<double> timeList = new List<double>();
        DateTime clock;
        double xAxisMinimum;
        double xAxisMaximum;

        int timeLeftToActivateMotion = 30;

        public static ProgramParameter ProgramParameter {get; set; }

        public Home()
        {
            InitializeComponent();


            SQLCom.AutoConnect();
            if (SQLCom.SuccessfullLogin == true)
            {
                SQL.ConnectionString = SQLCom.ConnectionString;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                Form frmServerConnect = new ServerConnect();
                frmServerConnect.ShowDialog();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
            }
            ProgramParameter = new ProgramParameter();
            ProgramParameter.PropertyChanged += IntervalChanged;
            tmrRead.Interval = ProgramParameter.ReadInterval * 1000;
            tmrLog.Interval = ProgramParameter.LogInterval * (1000 * 60);

            arduinoCom = new ArduinoCom();
            arduino = new Arduino(arduinoCom.SendCommandToArduino(Command.ReadStatus));

            lowTemperatureAlarm = new AlarmLowTemperature(SQL.GetAlarmLimit(AlarmtypesEnum.LowTemp));
            lowTemperatureAlarm.Temperature = arduino.Temperature;
            lowTemperatureAlarm.LowTemperatureAlarm += LowTemperatureAlarm;

            highTemperatureAlarm = new AlarmHighTemperature(SQL.GetAlarmLimit(AlarmtypesEnum.HighTemp));
            highTemperatureAlarm.Temperature = arduino.Temperature;
            highTemperatureAlarm.HighTemperatureAlarm += HighTemperatureAlarm;

            noChargeAlarm = new AlarmNoCharge();
            noChargeAlarm.PowerStatusChanged += UpdatePowerStatus;
            noChargeAlarm.NoChargeAlarm += NoChargeAlarm;
            UpdatePowerStatus(null, EventArgs.Empty);

            comFaultAlarm = new AlarmComFault();
            comFaultAlarm.ComFaultAlarm += ComFaultAlarm;

            motionAlarm = new AlarmMotion();
            motionAlarm.AlarmActivated = false;
            motionAlarm.MotionAlarm += MotionAlarm;

            lowBatteryAlarm = new AlarmLowBattery(SQL.GetAlarmLimit(AlarmtypesEnum.LowBattery));
            lowBatteryAlarm.LowBatteryAlarm += LowBatteryAlarm;

            InitGraph();

            tmrRead.Start();
            tmrLog.Start();

            Update();
            UpdateTop5Alarms();
        }

        // AlarmEvents
        #region AlarmEvents 

        private void ComFaultAlarm(object sender, EventArgs args)
        {
            SQL.NewAlarm(comFaultAlarm.AlarmType);

            emailList.Clear();
            emailList = SQL.GetEmailList(comFaultAlarm.AlarmType);
            Task sendEmailToSubscribersTask = Task.Factory.StartNew(() => SendEmailToSubscribers(emailList, comFaultAlarm.AlarmDescription));

            MessageBox.Show(comFaultAlarm.AlarmDescription, comFaultAlarm.AlarmTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            UpdateTop5Alarms();
        }


        private void MotionAlarm(object sender, EventArgs args)
        {
            SQL.NewAlarm(motionAlarm.AlarmType);

            arduinoCom.SendCommandToArduino(Command.Alarm);

            emailList.Clear();
            emailList = SQL.GetEmailList(motionAlarm.AlarmType);
            Task sendEmailToSubscribersTask = Task.Factory.StartNew(() => SendEmailToSubscribers(emailList, motionAlarm.AlarmDescription));

            MessageBox.Show(motionAlarm.AlarmDescription, motionAlarm.AlarmTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            UpdateTop5Alarms();
        }



        private void HighTemperatureAlarm(object source, EventArgs args)
        {
            SQL.NewAlarm(highTemperatureAlarm.AlarmType);

            arduinoCom.SendCommandToArduino(Command.Alarm);

            emailList.Clear();
            emailList = SQL.GetEmailList(highTemperatureAlarm.AlarmType);
            Task sendEmailToSubscribersTask = Task.Factory.StartNew(() => SendEmailToSubscribers(emailList, highTemperatureAlarm.AlarmDescription));

            MessageBox.Show(highTemperatureAlarm.AlarmDescription, highTemperatureAlarm.AlarmTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            UpdateTop5Alarms();
        }

        private void LowTemperatureAlarm(object source, EventArgs args)
        {
            SQL.NewAlarm(lowTemperatureAlarm.AlarmType);

            arduinoCom.SendCommandToArduino(Command.Alarm);

            emailList.Clear();
            emailList = SQL.GetEmailList(lowTemperatureAlarm.AlarmType);
            Task sendEmailToSubscribersTask = Task.Factory.StartNew(() => SendEmailToSubscribers(emailList, lowTemperatureAlarm.AlarmDescription));

            MessageBox.Show(lowTemperatureAlarm.AlarmDescription, lowTemperatureAlarm.AlarmTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            UpdateTop5Alarms();
        }

        void NoChargeAlarm(object sender, EventArgs e)
        {
            SQL.NewAlarm(noChargeAlarm.AlarmType);

            arduinoCom.SendCommandToArduino(Command.Alarm);

            emailList.Clear();
            emailList = SQL.GetEmailList(noChargeAlarm.AlarmType);
            Task sendEmailToSubscribersTask = Task.Factory.StartNew(() => SendEmailToSubscribers(emailList, noChargeAlarm.AlarmDescription));

            MessageBox.Show(noChargeAlarm.AlarmDescription, noChargeAlarm.AlarmTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            UpdateTop5Alarms();
        }

        void LowBatteryAlarm(object sender, EventArgs e)
        {
            SQL.NewAlarm(lowBatteryAlarm.AlarmType);

            arduinoCom.SendCommandToArduino(Command.Alarm);

            emailList.Clear();
            emailList = SQL.GetEmailList(lowBatteryAlarm.AlarmType);
            Task sendEmailToSubscribersTask = Task.Factory.StartNew(() => SendEmailToSubscribers(emailList, lowBatteryAlarm.AlarmDescription));

            MessageBox.Show(lowBatteryAlarm.AlarmDescription, lowBatteryAlarm.AlarmTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            UpdateTop5Alarms();
        }
        #endregion

        // Updates if power is connected
        void UpdatePowerStatus(object source, EventArgs e)
        {
            if (noChargeAlarm.PowerConnected == true)
            {
                lblPowerAdapter.Text = "Tilkoblet";
                lblPowerAdapter.ForeColor = SystemColors.Highlight;
            }
            else
            {
                lblPowerAdapter.Text = "Ikke tilkoblet";
                lblPowerAdapter.ForeColor = Color.Firebrick;
            }
        }

        // Inits graph with XaxisMin and Max
        private void InitGraph()
        {
            xAxisMinimum = DateTime.Now.ToOADate();
            xAxisMaximum = DateTime.Now.AddSeconds(ProgramParameter.ReadInterval * timeListLength).ToOADate();
            graph.ChartAreas[0].AxisX.Minimum = xAxisMinimum;
            graph.ChartAreas[0].AxisX.Maximum = xAxisMaximum;
        }

        // Updates graph data
        void UpdateGraphData()
        {
            clock = DateTime.Now;
            timeList.Add(clock.ToOADate());
            temperatureList.Add(arduino.Temperature);
            if (timeList.Count > timeListLength)
            {
                timeList.RemoveAt(0);
                temperatureList.RemoveAt(0);
            }
            xAxisMinimum = timeList[0];
            if (timeList.Count >= timeListLength) xAxisMaximum = timeList[timeListLength - 1];
        }

        // Updates graph with new data. Use task for datacalculations to save some resources on main thread.
        void UpdateGraph()
        {
            Task updateGraphDataTask = Task.Factory.StartNew(UpdateGraphData);
            Task.WaitAll(updateGraphDataTask);
            graph.Series[0].Points.Clear();
            graph.ChartAreas[0].AxisX.Minimum = xAxisMinimum;
            graph.ChartAreas[0].AxisX.Maximum = xAxisMaximum;

            for (int i = 0; i < timeList.Count; i++)
            {
                graph.Series[0].Points.AddXY(timeList[i], temperatureList[i]);
            }
        }

        // Updates top 5 alarms table
        void UpdateTop5Alarms()
        {
            string sqlQuery = @"SELECT TOP 5 Alarm as Alarmtype, Time as Tidspunkt FROM ALARM ORDER BY Time DESC";
            dgvTop5Alarms.DataSource = SQL.MakeDataGridView(sqlQuery);
        }
        /// <summary>
        /// Send email to subscribers based on emails list
        /// </summary>
        /// <param name="emails">List of emails to subscribers</param>
        /// <param name="alarmDescription">Description of alarmtype</param>
        /// <returns></returns>
        StringBuilder SendEmailToSubscribers(List<string> emails, string alarmDescription)
        {
            StringBuilder allEmails = new StringBuilder();
            mailArray = new Mail[emailList.Count];

            for (int i = 0; i <= mailArray.GetUpperBound(0); i++)
            {
                int index = i;
                mailArray[index] = new Mail(emailList[index], "Alarmsystem", alarmDescription);
            }
            for (int i = 0; i <= mailArray.GetUpperBound(0); i++)
            {
                int index = i;
                mailArray[index].Send();
            }
            for (int i = 0; i <= mailArray.GetUpperBound(0); i++)
            {
                int index = i;
                if (mailArray[index].EmailSent) allEmails.AppendLine(emails[index]);
            }
            return allEmails;
        }



        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddSubscriber = new AddSubscriber();
            frmAddSubscriber.ShowDialog(this);
        }

        private void administrateUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAdministrateSubscribers = new AdministrateSubscribers();
            frmAdministrateSubscribers.ShowDialog(this);
        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog(this);
        }


        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            CreatePdf();
        }

        void CreatePdf()
        {
            string sqlQuery = @"SELECT Alarm as Alarmtype, Time as Tidspunkt FROM ALARM ORDER BY Time DESC";
            PdfForm.CreatePdf("Viser alle alarmer i databasen", SQL.MakeDataGridView(sqlQuery));
        }

        private void btnShowAlarmlist_Click(object sender, EventArgs e)
        {
            AlarmList frmAlarmList = new AlarmList();
            frmAlarmList.ShowDialog(this);
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            Task createPdfTask = Task.Factory.StartNew(() => CreatePdf());
            SendEmail frmSendEmail = new SendEmail();
            Task.WaitAll(createPdfTask);
            frmSendEmail.ShowDialog(this);
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            HistoricGraph frmGraph = new HistoricGraph();
            frmGraph.Show();
        }
        
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings();
            frmSettings.ShowDialog(this);
            lowBatteryAlarm.LowBatteryLimit = SQL.GetAlarmLimit(lowBatteryAlarm.AlarmType);
            lowTemperatureAlarm.LowTemperatureLimit = SQL.GetAlarmLimit(lowTemperatureAlarm.AlarmType);
            highTemperatureAlarm.HighTemperatureLimit = SQL.GetAlarmLimit(highTemperatureAlarm.AlarmType);
        }

        private void IntervalChanged (object sender, EventArgs e)
        {
            tmrRead.Interval = ProgramParameter.ReadInterval * 1000;
            tmrLog.Interval = ProgramParameter.LogInterval * (1000 * 60);
        }
        
        private void btnActivateMotionAlarm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bevegelsesdetektor vil aktiveres innen 30 sekund", "Bevegelsesdetektor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timeLeftToActivateMotion = 30;
            tmrActivateMotion.Start();
            lblMotion.Text = "Aktiverer - " + timeLeftToActivateMotion;
            lblMotion.ForeColor = Color.Goldenrod;

        }

        private void btnDeactivateMotionAlarm_Click(object sender, EventArgs e)
        {
            tmrActivateMotion.Stop();
            motionAlarm.AlarmActivated = false;
            lblMotion.Text = "Deaktivert";
            lblMotion.ForeColor = SystemColors.Highlight;
        }

        private void tmrRead_Tick(object sender, EventArgs e)

        {
            arduino.Update(arduinoCom.SendCommandToArduino(Command.ReadStatus));
            lowTemperatureAlarm.Temperature = arduino.Temperature;
            highTemperatureAlarm.Temperature = arduino.Temperature;
            motionAlarm.InAlarm = arduino.PirEnabled;
            comFaultAlarm.ArduinoConnected = arduino.Connected;
            lblTemperature.Text = arduino.Temperature.ToString() + " °C";
            lblBatteryPercent.Text = lowBatteryAlarm.CurrentBatteryPercent.ToString() + " %";
            if (arduino.Connected) lblArduinoConnected.Text = "Connected";
            else lblArduinoConnected.Text = "Not Connected";
            if (lowBatteryAlarm.CurrentBatteryPercent > lowBatteryAlarm.LowBatteryLimit) lblBatteryPercent.ForeColor = SystemColors.Highlight;
            else lblBatteryPercent.ForeColor = Color.Firebrick;
            UpdateGraph();
        }

        private void tmrActivateMotion_Tick(object sender, EventArgs e)
        {
            if (timeLeftToActivateMotion > 0)
            {
                timeLeftToActivateMotion = timeLeftToActivateMotion - 1;
                lblMotion.Text = "Aktiverer - " + timeLeftToActivateMotion;
            }
            else
            {
                tmrActivateMotion.Stop();
                motionAlarm.AlarmActivated = true;
                lblMotion.Text = "Aktivert";
                lblMotion.ForeColor = SystemColors.Highlight;
            }
        }

        private void tmrLog_Tick(object sender, EventArgs e)
        {
            SQL.LogTemp( arduino.Temperature);
        }
    }            


}
