using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace parameter_class
{

    public class ProgramParameter : INotifyPropertyChanged
    {
        private string filename;
        private int[] intervals = new int[2];

        public event PropertyChangedEventHandler PropertyChanged;

        public ProgramParameter(int readInterval, int logInterval, string path)
        {
            filename = path;
            ReadInterval = readInterval;
            LogInterval = logInterval;
            SaveToFile();
        }

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
                else throw new ArgumentOutOfRangeException("ReadInterval må være innenfor 2 og 10 sekunder");
            }
        }
        public int LogInterval
        {
            get { return intervals[1]; }
            set
            {
                if (value > 0 && value <= 600)
                {
                    intervals[1] = value;
                    OnPropertyChanged("LogInterval");
                    SaveToFile();
                }
                else throw new ArgumentOutOfRangeException("ReadInterval må være innenfor 2 og 10 sekunder");
            }
        }

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

        public int[] ReadFromFile()
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            foreach (int i in intervals)
            {
                intervals[i] = Convert.ToInt32(sr.ReadLine());
            }
            return intervals;
        }
        
        protected virtual void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }


    }
}
