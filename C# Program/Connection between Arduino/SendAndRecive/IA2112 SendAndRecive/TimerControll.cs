using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA2112_SendAndRecive
{
    class TimerControll
    {
        public bool StopThread { get; set; }
        public int Intervall { get; set; }
        #region Set Timer for communication with arduino

        public System.Timers.Timer times = new System.Timers.Timer();
        public System.Timers.Timer times2 = new System.Timers.Timer();
        #endregion

        #region TimerControll constructor
        public TimerControll(bool stopThread, int intervall)
        {
            this.StopThread = stopThread;
            this.Intervall = intervall;
        }
        public TimerControll() { }
        #endregion

        /// <summary>
        /// Finish: 26.03.2016
        /// Set timers intervall to communicate with arduino
        /// </summary>
        /// <returns></returns>
        public int GetTimerIntervall()
        {
            // for min //
            //return (Intervall * 1000) * 60;

            //for sek //
            return Intervall * 1000;

        }
    }
}
