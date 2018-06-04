using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prosjekt
{
    class Arduino
    {
        #region
        private List<string> ArduinoValuelist = new List<string>(); //local list
        private string data;                                  
        private string rawData;
        private double temp;
        private bool pirEnabled;
        public bool Connected { get; protected set; }
        #endregion

        public Arduino(string data)
        {
            if (data != null)
            {
                Connected = true;
                rawData = data;
                SplittTekst();
                CheckPirValue();
                CheckTemperatureValue();
            }
            else Connected = false;
        }

        /// <summary>
        /// Finish: 22.03.2016
        /// Trim data string.
        /// Store all value in each different row in list.
        /// </summary>
        /// <param name="value"></param>
        private void SplittTekst()
        {
            data = rawData;
            data = data.Replace("\t", "");                
            data = data.Replace("\r", "");
            data = data.Replace('.', ',');               
            ArduinoValuelist = data.Split(' ').ToList();
        }

        /// <summary>
        /// Finish: 25.03.2016
        /// Determine if Pir state is On or Off
        /// Return true or false to PirEnabled
        /// </summary>
        /// <returns></returns>
        private void CheckPirValue()
        {
            pirEnabled = false;
            foreach (var c in ArduinoValuelist)
            {
                if (c.StartsWith("#P:"))
                {
                        string pir = c;

                        if (pir.Contains("ON")) pirEnabled = true;
                        else pirEnabled = false;
                }
            }
        }

        /// <summary>
        /// Finish: 25.03.2016
        /// Split temp from ArduinoValueList to Temperature property
        /// </summary>
        private void CheckTemperatureValue()
        {
            foreach (string val in ArduinoValuelist)
            {
                if (val.StartsWith("#T:"))
                {
                    string temporary = val;
                    temporary = temporary.Remove(0, 3);
                    temp = Convert.ToDouble(temporary);
                }
            }
        }

        /// <summary>
        /// Updates properties if arduino is connected
        /// </summary>
        /// <param name="data">If string is empty, arduino is not connected</param>
        public void Update(string data)
        {
            if (data != null)
            {
                Connected = true;
                rawData = data;
                SplittTekst();
                CheckPirValue();
                CheckTemperatureValue();
            }
            else Connected = false;
        }

        public double Temperature
        {
            get { return temp; }
        }

        public bool PirEnabled
        {
            get { return pirEnabled; }
        }
    }
}
