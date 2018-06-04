using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;


namespace IA2112_SendAndRecive
{
    public partial class Form1 : Form
    {
        
        SetPortAndBaud setPortAndBaud = new SetPortAndBaud();
        Alarm alarm = new Alarm();
        private TimerControll Timer = new TimerControll();
        private double max = 0.0;
        private double min = 0.0;

        #region Events and Handlers
        public delegate void WriteOutResult();
       
        #endregion

        public Form1()
        {
            InitializeComponent();
        
        }

        private void cboMaxTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            max = double.Parse( cboMaxTemp.Text);
            Alarm.SetTempLimit(max, min);
        }
        private void cboMinTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
           min = double.Parse(cboMinTemp.Text);
           Alarm.SetTempLimit(max, min);
        }
        private void btnGetValue_Click(object sender, EventArgs e)      
        {
            Timer.Intervall = 2;                                                                 // Set the Main code intervall
            
            Alarm.SetTempLimit(max,min);                                                         // Temp Max and Min
            SetPortAndBaud.SetPortAndValue(9600);                                                // Set Port and baud to serialport
            Alarm.EnablePirDetectorSettings(true);                                              //Enable Pir Detector
            Timer.times.Interval = Timer.GetTimerIntervall();                                   // Intervall for Main code
            Timer.times.Elapsed += ConnectionFactor;                                          //Sets after the intervall, Runs the main code
            SetPortAndBaud.NoArduinoConnection += EventHandlerForNoConnection;               //Call event for No connection to arduino
            if (SetPortAndBaud.IfNoPortIsSett)
            {
                Timer.times.Start();                                                             // starts the main code timer
            }


        }
        
        #region These code are for writing out results/process data value
        /// <summary>
        /// Finish: 12.04.2016
        /// Making a thread-safe call.
        /// Checks if the calling thread is different from the created thread.
        /// If its different, then this methode call itself asynchronously using the invoke methode.
        /// If not different, then send value to be store at database
        /// </summary>
        public  void GetAlarmStatusAndDataValue()
        {
            IList coList = alarm;
            if (this.txtShow.InvokeRequired)
            {
                WriteOutResult d = GetAlarmStatusAndDataValue;
                this.Invoke(d, new object[] {});
            }
            else
            {       //Use this to send value to get the process value from arduino 
                    // delete this after change
                this.txtShow.AppendText("AlarmStatus: " + coList.Value + "\n");         
                this.txtShow.AppendText("PirStatus: " + Alarm.PirResult + "\n");
                this.txtShow.AppendText("TempStatus: " + Alarm.TemperatureResult + "\n");
                this.txtShow.AppendText("\n");
            }
        }

        #endregion

        #region This code are for events
  
        //Use this to have the event on No Connection to arduino!!
        public void EventHandlerForNoConnection(object source, EventArgs args)
        {
            Timer.times.Stop();
            Timer.times.Elapsed -= ConnectionFactor;
            Alarm.AddToArduinoValueList("0");
            MessageBox.Show("No connection to arduino");
        }
        #endregion

        #region This code are for checking if string command code are empty

        /// <summary>
        /// Finish: 15.04.2016
        /// Checking if the Main code return any command
        /// if it does not, it will return "1" as standard
        /// </summary>
        /// <returns></returns>
        public string CheckStringIsNullOrEmpty() //This is need for the value from interface is empty
        {
            IList coList = alarm;
            if (string.IsNullOrEmpty(coList.Value)) return "1";
            return coList.Value;
        }
        #endregion

        #region This code are for Sending and reciving data value from Arduino
        /// <summary>
        /// Finish: 17.04.2016
        /// Main methode to communicate arduino with command
        /// 2) Start individual thread to check the data if there are any alarm trigger.
        /// 3) Send the check data to database.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        public void ConnectionFactor(object source, System.Timers.ElapsedEventArgs args)            
        {
            Timer.StopThread = false;
            Alarm.MainConnectionToArduino(CheckStringIsNullOrEmpty(), setPortAndBaud);
            // (2)
            var t1 = Task.Factory.StartNew(() => Alarm.AlarmTriggerCheck(setPortAndBaud));
            var task = t1;                   
            Task.WaitAll(task);
            // (3)
            GetAlarmStatusAndDataValue();                             
        }
 
        #endregion

        #region This is just test code for manual controll of stopping and reset arduino. Deletable
        
        /// <summary>
        /// This is just for simulate the stop and reset the code.
        /// Delete this is a option...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Timer.times.Stop();
            Timer.times.Elapsed -= ConnectionFactor; 
            SetPortAndBaud.SendOnlySingleCommand("8");                 
            SetPortAndBaud.ClosePort();
        }

        /// <summary>
        /// This is just for simulate the clear funksjon both c# and arduino
        /// with the use of command: 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtClear_Click(object sender, EventArgs e)
        {
            txtShow.Clear();
            SetPortAndBaud.SendOnlySingleCommand("7");
            SetPortAndBaud.ClosePort();
        }

        #endregion

        
    }

    /// <summary>
    /// Interface function are to gather all the data from different process.
    /// </summary>
    public  interface IList         
    {   
        string Value { get; set; }                                                         // Store result data from all class

    }
   
}
