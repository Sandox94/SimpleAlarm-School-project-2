using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IA2112_SendAndRecive
{
    public class Alarm : SetPortAndBaud, IList
    {
        private static List<string> ArduinoValueList { get; set; } = new List<string>();        // Local list
        private static string AlarmCommandoStatus = "";                                         // Store Alarm trigger commando
        private static bool EnablePirDetector;                                                  // Store for enable Pir Alarm
        private static double MaxTemp;                                                          // Store Max temperature
        private static double MinTemp;                                                          // Store Min temperature
        public static string PirResult { get; set; }                                            // Pir Result
        public static double TemperatureResult { get; set; }                                    // Temperatur Result

        public string Value                                                                     // Return command on what has been trigger
        {
            get { return AlarmCommandoStatus; }
            set { AlarmCommandoStatus = value; }
        }                                                          

        /// <summary>
        /// Finish: 21.03.2016
        /// After user choise to set the max and min temperature value
        /// </summary>
        /// <param name="Max"></param>
        /// <param name="Min"></param>
        public static void SetTempLimit(double Max, double Min)          // user change
        {
            MaxTemp = Max;
            MinTemp = Min;
        }
       
        public static void EnablePirDetectorSettings(bool state)
        {
            EnablePirDetector = state;
        }

        public static void AddToArduinoValueList(string value)
        {
            ArduinoValueList.Add(value);
        }

        #region Code for check if there is any alarm trigger

        /// <summary>
        /// Finish: 25.03.2016
        /// Determine if user enable pir detector
        /// Determine if Pir state is On or Off
        /// Return as 1 or 0 to AlarmTempTest
        /// </summary>
        /// <returns></returns>
        public static int CheckPirValue()             
        {
            int PirCheck = 0;
            if (EnablePirDetector)
            {
                foreach (var c in ArduinoValueList)
                {
                    if (c.StartsWith("#P:"))
                    {
                        string pir = c;
                        if (pir.Contains("ON")) PirCheck = 1; 
                        else PirCheck = 0; 
                    }

                }
            }
            PirValueResult();
            return PirCheck;
        }
        /// <summary>
        /// Finish: 07.03.2016
        /// Read from local list for data value
        /// Check if Pir status is "On" or "Off"
        /// Return the result to PirResult
        /// </summary>
        public static void PirValueResult()
        {
            if (EnablePirDetector)
            {
                foreach (var c in ArduinoValueList)
                {
                    if (c.StartsWith("#P:"))
                    {
                        string b = c;
                        b = b.Remove(0, 3);
                        PirResult = b;
                    }
                }
            }
            else PirResult = "OFF";
        }

        /// <summary>
        /// Finish: 25.03.2016
        /// Determine if temperature value is in the frame of Max and Min
        /// Return as 2(Max) or 3(Min) to AlarmTempTest
        /// </summary>
        /// <returns></returns>
        public static int CheckTemperatureValue()           
        {
            int TempCheck = 0;
            double TempValue = 0.0;

            foreach (var c in ArduinoValueList)
            {
                if (c.StartsWith("#T:"))
                {
                    string b = c;
                    b = b.Remove(0, 3);
                    b = b.Replace(',', '.');
                    if (double.TryParse(b, out TempValue))
                        {
                           if (TempValue > MaxTemp) TempCheck = 2;
                           else if (TempValue < MinTemp) TempCheck = 3;
                        }
                    
                    if (c.StartsWith("#T:"))
                    {
                        string a = c;
                        a = a.Remove(0, 3);
                        a = a.Replace(',', '.');
                        TemperatureResult = Convert.ToDouble(a);
                    }
                }
            }
            return TempCheck;
        }

        /// <summary>
        /// Finish: 25.03.2016
        /// See if any returnet value from pir and temperatur triggers alarm
        /// if they do, return the command line to interface for communication to arduino.
        /// if not any alarm, then return "1" as default.
        /// </summary>
        /// <param name="auto"></param>
        public static void AlarmTriggerCheck(SetPortAndBaud auto)
        {
            var TemperatureResult = CheckTemperatureValue();       
            var PirResult = CheckPirValue();

            if (PirResult == 1 && TemperatureResult == 2) AlarmCommandoStatus = ("2");          //Alarmstatus: Pir and Max temperatur
          
            else if (PirResult == 1 && TemperatureResult == 3) AlarmCommandoStatus = ("3");     //Alarmstatus: Pir and Min temperatur
          
            else if (PirResult == 1) AlarmCommandoStatus = ("4");                               //Alarmstatus: Pir
        
            else if (TemperatureResult == 2) AlarmCommandoStatus = ("5");                       //Alarmstatus: Max temperatur
           
            else if (TemperatureResult == 3) AlarmCommandoStatus = ("6");                       // Alarmstatus: Min temperatur
          
            else AlarmCommandoStatus = ("1");                                                   //Alarmstatus: No alarm given
            ArduinoValueList.Clear();
        }
        #endregion

        /// <summary>
        /// Finish: 22.03.2016
        /// Inheritate from Class SetPortAndBaud
        /// Sends the command to arduino to get data string.
        /// Get the result string back, and send it to process.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="Port"></param>
        public static void MainConnectionToArduino(string command, SetPortAndBaud port)
        {
            SplittTekst(port.SendCommandToArduino(command));
        }

        /// <summary>
        /// Finish: 22.03.2016
        /// Trim away the noise from data string.
        /// Store all value in each different row in list.
        /// </summary>
        /// <param name="value"></param>
        public static void SplittTekst(string value)
        {
            //if (SetPortAndBaud.IfNoPortIsSett)
            //{
            //    try
            //    {
                    string Value = value.Replace('\t', ' ');                // local value, not from interface.
                    Value = Value.Replace('.', ',');                // For the comma and punctual difference.
                    ArduinoValueList = Value.Split(' ').ToList();           // add all value back to local list
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Waiting for data value");
            //    }
            //}
            //MessageBox.Show("There is no connection to Arduino");

        }
    }
}