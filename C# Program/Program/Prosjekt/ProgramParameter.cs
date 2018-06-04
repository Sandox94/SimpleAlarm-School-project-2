using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace Prosjekt
{
    // Class to save and read log- and readinterval.
    // File saved as cfg file in the same folder as program.exe
    public class ProgramParameter : INotifyPropertyChanged
    {
        private string filename = "config.cfg";
        private int[] intervals = new int[2];

        public event PropertyChangedEventHandler PropertyChanged;

        // Constructor
        public ProgramParameter()
        {
            ReadFromFile();
            if (ReadInterval == 0) ReadInterval = 5;
            if (LogInterval == 0) LogInterval = 5;
        }

        // Alternative constructor that is not used
        public ProgramParameter(int readInterval, int logInterval, string path)
        {
            filename = path;
            ReadInterval = readInterval;
            LogInterval = logInterval;
            SaveToFile();
        }

        // Readinterval property, save to file when set
        public int ReadInterval
        {
            get { return intervals[0]; }
            set
            {
                if (value >= 2 && value <= 10)
                {
                    intervals[0] = value;
                    OnPropertyChanged("ReadInterval");
                    SaveToFile();
                }
                else throw new ArgumentOutOfRangeException("ReadInterval må være mellom 2 og 10 sekunder");
            }
        }

        // Loginterval property, save to file when set
        public int LogInterval
        {
            get { return intervals[1]; }
            set
            {
                if (value >= 1 && value <= 60)
                {
                    intervals[1] = value;
                    OnPropertyChanged("LogInterval");
                    SaveToFile();
                }
                else throw new ArgumentOutOfRangeException("LogInterval må være mellom 1 og 60 min");
            }
        }

        /// <summary>
        /// Saves log- and readinterval to file
        /// </summary>
        public void SaveToFile()
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (int i in intervals)
            {
                sw.WriteLine(i);
            }
            sw.Close();
        }

        /// <summary>
        /// Reads log- and readinterval from file
        /// </summary>
        /// <returns></returns>
        public int[] ReadFromFile()
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            for (int i = 0; i <= intervals.GetUpperBound(0); i++)
            {
                intervals[i] = Convert.ToInt32(sr.ReadLine());
            }

            sr.Close();
            return intervals;
        }
        
        // Propery changed event inherited from interface
        protected virtual void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }


    }
}
