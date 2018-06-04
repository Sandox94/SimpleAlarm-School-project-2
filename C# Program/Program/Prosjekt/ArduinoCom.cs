using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using  System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Prosjekt
{
    public enum Command { ReadStatus = 1, Alarm = 2 }

    public class ArduinoCom
    {
        SerialPort Port = new SerialPort();
        public event EventHandler NoArduinoConnection;

        private int connectAttempts = 0;

        private string ComName;
        private int BaudRate;
        public string Commando = "";

        #region Constructor

        public ArduinoCom(string Com, int baud)
        {
            ComName = Com;
            BaudRate = baud;
        }
        public ArduinoCom()
        {
            AutoSetPortName();
        }
        #endregion

        #region Set and get Comport name and BaudRate

        /// <summary>
        /// Finish: 19.03.2016
        /// Get Com name and Baud rate
        /// And set them to Serialport
        /// </summary>
        /// <param name="Com"></param>
        /// <param name="Baud"></param>
        public void ManualSetPortAndBaudValue(string Com, int Baud)
        {
            ComName = Com;
            BaudRate = Baud;
            SetPortAndValue();
        }
        public void ManuelSetBaud(int baud)                                     // Set the communication speed
        {
            BaudRate = baud;
        }

        /// <summary>
        /// Finish: 19.03.2016
        /// Find arduino port name.
        /// Store the port name to ComName.
        /// </summary>
        public void AutoSetPortName()
        {
            foreach (string portName in SerialPort.GetPortNames())
            {
                Port = new SerialPort(portName);
                if (Port.IsOpen == false) ComName = portName;
            }

        }

        public void SetPortAndValue()
        {
            try
            {
                Port.PortName = ComName;
            }
            catch (Exception)
            {
                MessageBox.Show("No Connection to Arduino");
            }

            Port.BaudRate = BaudRate;
        }                                       // Sett the Port And Baud
        #endregion

        #region These code are use for open and send command to arduino

        /// <summary>
        /// Finish: 22.03.2016
        /// Send command code to request data value from arduino
        /// Check if port is open, and check if arduino is connected
        /// Rais a event to say there is not connection
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public string SendCommandToArduino(Command command)
        {
            string ArduinoValue = null;
            if (Port.IsOpen)
            {
                try
                {
                    if (command == Command.ReadStatus)
                    {
                        Port.Write("1");
                        ArduinoValue = Port.ReadLine();
                    }
                    else if (command == Command.Alarm)
                    {
                        Port.Write("2");
                        ArduinoValue = Port.ReadLine();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Port is Busy right now");
                }
            }
            else if (connectAttempts > 5)
            {
                AutoSetPortName();
                connectAttempts = 0;
            }
            else
            {
                try
                {
                    Port.Open();
                    if (command == Command.ReadStatus)
                    {
                        Port.Write("1");
                        ArduinoValue = Port.ReadLine();
                    }
                    else if (command == Command.Alarm)
                    {
                        Port.Write("2");
                        ArduinoValue = Port.ReadLine();
                    }
                }
                catch (Exception)
                {
                    connectAttempts++;
                    if (NoArduinoConnection != null) NoArduinoConnection(this, EventArgs.Empty);
                }
            }
            return ArduinoValue;
        }

        /// <summary>
        /// Finish: 22.03.2016
        /// Only use for testing
        /// Send command line "7" to stop/reset arduino
        /// </summary>
        /// <param name="command"></param>
        public void SendOnlySingleCommand(string command)
        {
            if (Port.IsOpen) Port.Write(command);
            else
            {
                try
                {
                    Port.Open();
                    Port.Write(command);
                }
                catch (Exception)
                {
                    MessageBox.Show("Port is Busy right now");
                }
            }
        }
        public void SendOnlySingleCommand()
        {
            if (Port.IsOpen) Port.Write(Commando);
            else
            {
                Port.Open();
                Port.Write(Commando);
            }
        }
        public void ClosePort()
        {
            if (Port.IsOpen) Port.Close();
            else Port.Close();
        }
        #endregion

    }
}
