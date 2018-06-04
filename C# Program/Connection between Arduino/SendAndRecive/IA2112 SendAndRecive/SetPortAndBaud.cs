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

namespace IA2112_SendAndRecive
{
   
    public class SetPortAndBaud
    {
        private static SerialPort port;
        public static event EventHandler NoArduinoConnection;
        private static string comName;
        private static int baudRate;
        private static string commando = "";
        private static string ArduinoValue;
        public static bool IfNoPortIsSett;

        #region Constructor
        static SetPortAndBaud()
        {
            AutoSetPortName();
        }
        #endregion

        #region Set and get Comport name and BaudRate

        /// <summary>
        /// Finish: 19.03.2016
        /// Finde arduino port name.
        /// Store the port name to ComName.
        /// </summary>
        public static void AutoSetPortName()                                          
        {
            foreach (string portName in SerialPort.GetPortNames())
            {
                port = new SerialPort(portName);
                if (port.IsOpen == false) comName = portName;
            }

        }

        public static void SetPortAndValue(int baud)
        {
            try
            {
                port.PortName = comName;
                port.BaudRate = baud;
                IfNoPortIsSett = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No Connection to Arduino");
                IfNoPortIsSett = false;
            }
            
                
        }                                       // Sett the port And Baud
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
        public string SendCommandToArduino(string command)
        {
            if (IfNoPortIsSett)
            {

                if (port.IsOpen)
                {
                    try
                    {
                        port.Write(command);
                        ArduinoValue = port.ReadLine();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("port is Busy right now");
                    }
                }
                else
                {
                    try
                    {
                        port.Open();
                        port.Write(command);
                        ArduinoValue = port.ReadLine();
                    }
                    catch (Exception)
                    {
                        NoArduinoConnection?.Invoke(this, EventArgs.Empty);
                    }
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
        public static void SendOnlySingleCommand(string command)
        {
            if (port.IsOpen) port.Write(command);
            else
            {
                try
                {
                    port.Open();
                    port.Write(command);
                }
                catch (Exception)
                {
                    MessageBox.Show("port is Busy right now");
                }
            }
        }
     
        public static void ClosePort()
        {
            if (port.IsOpen) port.Close();
            else port.Close();
        }
        #endregion

    }
}
